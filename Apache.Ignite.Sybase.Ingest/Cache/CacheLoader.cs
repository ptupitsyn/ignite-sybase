using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Discovery.Tcp;
using Apache.Ignite.Core.Discovery.Tcp.Static;
using Apache.Ignite.NLog;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;
using GridGain.Core;
using Newtonsoft.Json;
using NLog;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public static class CacheLoader
    {
        private static DateTime _loadStartTime = DateTime.Now;
        private static long _key;

        public static void LoadFromPath(string dir)
        {
            var recordDescriptors = CtrlGenParser.ParseAll(dir)
                .OrderBy(d => d.InFile)
                .ToArray();

            var cfg = GetIgniteConfiguration();
            using (var ignite = Ignition.Start(cfg))
            {
                DeleteCaches(ignite);
                CreateCaches(recordDescriptors, ignite);

                var sw = Stopwatch.StartNew();
                _loadStartTime = DateTime.Now;
                var dataFiles = new ConcurrentBag<DataFileInfo>();

                var descsAndFiles = recordDescriptors
                    .SelectMany(d => d.GetDataFilePaths(dir).Select(p => (Desc: d, Path: p)))
                    .ToArray();

                // ReSharper disable once AccessToDisposedClosure (not an issue).
                Parallel.ForEach(
                    descsAndFiles,
                    new ParallelOptions {MaxDegreeOfParallelism = 40},
                    descAndFile => InvokeLoadCacheGeneric(descAndFile.Desc, descAndFile.Path, ignite, dataFiles));

                var elapsed = sw.Elapsed;

                var cacheNames = ignite.GetCacheNames();
                var totalItems = cacheNames.Sum(n => ignite.GetCache<int, int>(n).GetSize());

                // TODO: Add stats on Ignite Memory Region size (compare to loaded data size).
                var log = LogManager.GetLogger(nameof(LoadFromPath));
                var dataFilesJson = JsonConvert.SerializeObject(dataFiles.ToArray());
                log.Info($" * {dataFiles.Count} data files loaded: {dataFilesJson}");
                log.Info("======= Loading complete ========");
                log.Info($" * {cacheNames.Count} caches");
                log.Info($" * {totalItems} cache entries");
                log.Info($" * {elapsed} elapsed, {totalItems / elapsed.TotalSeconds} entries per second.");

                var totalGzippedSizeGb = dataFiles.Sum(f => f.CompressedSize) / 1024 / 1024 / 1024;
                var totalSizeGb = dataFiles.Sum(f => f.Size)  / 1024 / 1024 / 1024;
                log.Info($" * {totalGzippedSizeGb} GB gzipped, {totalSizeGb} raw");
                log.Info($" * {(double) totalGzippedSizeGb / elapsed.TotalSeconds} GB per second gzipped.");
                log.Info($" * {(double) totalSizeGb / elapsed.TotalSeconds} GB per second raw.");
            }
        }

        private static void CreateCaches(RecordDescriptor[] recordDescriptors, IIgnite ignite)
        {
            // Create caches sequentially to avoid "too many remaps".
            foreach (var desc in recordDescriptors)
            {
                InvokeCreateCacheGeneric(desc, ignite);
            }
        }

        private static void DeleteCaches(IIgnite ignite)
        {
            foreach (var cacheName in ignite.GetCacheNames())
            {
                ignite.DestroyCache(cacheName);
            }
        }

        private static IgniteConfiguration GetIgniteConfiguration()
        {
            return new IgniteConfiguration
            {
                DiscoverySpi = new TcpDiscoverySpi
                {
                    IpFinder = new TcpDiscoveryStaticIpFinder
                    {
                        // Endpoints = new[] {"127.0.0.1:47500..47501"}
                        Endpoints = new[]
                        {
                            "lpwhdjdnd01.npd.com",
                            "lpwhdjdnd02.npd.com",
                            "lpwhdjdnd03.npd.com",
                            "lpwhdjdnd04.npd.com",
                            "lpwhdjdnd05.npd.com",
                            "lpwhdjdnd06.npd.com",
                            "lpwhdjdnd07.npd.com"
                        }
                    }
                },
                JvmInitialMemoryMb = 9000,
                JvmMaxMemoryMb = 19000,
                ClientMode = true,
                Logger = new IgniteNLogLogger(),
                PluginConfigurations = new[]
                {
                    new GridGainPluginConfiguration()
                },
                IgniteHome = "/opt/ignite/gridgain-ultimate-fabric-8.4.9"
            };
        }



        /// <summary>
        /// Uses model classes to load the cache.
        /// <see cref="ICanReadFromRecordBuffer"/> is the most efficient way to decode source data.
        /// <see cref="IBinarizable"/> is the most efficient way to pass data to Ignite.
        /// </summary>
        private static void LoadCacheGeneric<T>(IIgnite ignite, RecordDescriptor desc, string dataFilePath,
            ConcurrentBag<DataFileInfo> dataFiles)
            where T : ICanReadFromRecordBuffer, new()
        {
            var log = LogManager.GetLogger(nameof(LoadCacheGeneric));

            try
            {
                var cache = ignite.GetCache<long, T>(desc.TableName);

                using (var streamer = ignite.GetDataStreamer<long, T>(cache.Name))
                {
                    log.Info($"Starting {dataFilePath}...");
                    var entryCount = 0;

                    using (var reader = desc.GetBinaryRecordReader(dataFilePath))
                    {
                        var buffer = new byte[desc.Length];

                        while (reader.Read(buffer))
                        {
                            var entity = new T();
                            entity.ReadFromRecordBuffer(buffer);

                            // ReSharper disable once AccessToDisposedClosure (not an issue).
                            var key = Interlocked.Increment(ref _key);
                            streamer.AddData(key, entity);
                            entryCount++;
                        }
                    }

                    dataFiles.Add(new DataFileInfo(
                        dataFilePath,
                        new FileInfo(dataFilePath).Length,
                        (long) entryCount * desc.Length,
                        entryCount));

                    var totalGzippedSizeGb = (double) dataFiles.Sum(f => f.CompressedSize) / 1024 / 1024 / 1024;
                    var totalSizeGb = (double) dataFiles.Sum(f => f.Size) / 1024 / 1024 / 1024;
                    var time = DateTime.Now - _loadStartTime;
                    var rate = totalSizeGb * 1024 / time.TotalSeconds;
                    log.Info($" * Loaded so far: {totalGzippedSizeGb} GB gzipped, {totalSizeGb} raw, {rate} MiB/s");
                }
            }
            catch (Exception e)
            {
                log.Error(e, $"Failed to load {desc.InFile}: {e}");
            }
        }

        private static void InvokeLoadCacheGeneric(RecordDescriptor desc, string dir, IIgnite ignite,
            ConcurrentBag<DataFileInfo> dataFiles)
        {
            // A bit of reflection won't hurt once per table.
            var method = typeof(CacheLoader)
                .GetMethod(nameof(LoadCacheGeneric), BindingFlags.Static | BindingFlags.NonPublic);

            var genericMethod = method.MakeGenericMethod(desc.GetModelType());

            genericMethod.Invoke(null, new object[] {ignite, desc, dir, dataFiles});
        }

        private static void InvokeCreateCacheGeneric(RecordDescriptor desc, IIgnite ignite)
        {
            // A bit of reflection won't hurt once per table.
            var method = typeof(CacheLoader)
                .GetMethod(nameof(CreateCacheGeneric), BindingFlags.Static | BindingFlags.NonPublic);

            var genericMethod = method.MakeGenericMethod(desc.GetModelType());

            genericMethod.Invoke(null, new object[] {ignite, desc});
        }

        private static ICache<long, T> CreateCacheGeneric<T>(IIgnite ignite, RecordDescriptor desc)
        {
            var cacheCfg = new CacheConfiguration
            {
                Name = desc.TableName,
                QueryEntities = new[]
                {
                    new QueryEntity
                    {
                        TableName = desc.TableName,
                        KeyType = typeof(long),
                        ValueType = typeof(T)
                    }
                },
                EnableStatistics = true
            };

            return ignite.GetOrCreateCache<long, T>(cacheCfg);
        }

        private class DataFileInfo
        {
            public DataFileInfo(string path, long compressedSize, long size, long entries)
            {
                Path = path;
                CompressedSize = compressedSize;
                Size = size;
                Entries = entries;
            }

            public string Path { get; }
            public long CompressedSize { get; }
            public long Size { get; }
            public long Entries { get; }
            public float CompressionRatio => (float) Size / CompressedSize;
        }
    }
}
