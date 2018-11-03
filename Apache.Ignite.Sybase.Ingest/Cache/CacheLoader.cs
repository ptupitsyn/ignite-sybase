using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Discovery.Tcp;
using Apache.Ignite.Core.Discovery.Tcp.Static;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;
using JetBrains.Annotations;
using NLog;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public static class CacheLoader
    {
        public static void LoadFromPath(string dir)
        {
            // TODO: Load only 10 for a quick test.
            var recordDescriptors = CtrlGenParser.ParseAll(dir).ToArray();

            var cfg = GetIgniteConfiguration();
            var ignite = Ignition.Start(cfg);

            var sw = Stopwatch.StartNew();

            Parallel.ForEach(recordDescriptors, desc => InvokeLoadCacheGeneric(dir, desc, ignite));

            var elapsed = sw.Elapsed;

            var cacheNames = ignite.GetCacheNames();
            var totalItems = cacheNames.Sum(n => ignite.GetCache<int, int>(n).GetSize());

            var log = LogManager.GetLogger(nameof(LoadFromPath));
            log.Info("Loading complete:");
            log.Info($" * {cacheNames.Count} caches");
            log.Info($" * {totalItems} cache entries");
            log.Info($" * {elapsed} elapsed, {totalItems / elapsed.TotalSeconds} entries per second.");
        }

        private static IgniteConfiguration GetIgniteConfiguration()
        {
            return new IgniteConfiguration
            {
                DiscoverySpi = new TcpDiscoverySpi
                {
                    IpFinder = new TcpDiscoveryStaticIpFinder
                    {
                        Endpoints = new[] {"127.0.0.1:47500..47501"}
                    },
                    SocketTimeout = TimeSpan.FromSeconds(0.3)
                },
                JvmInitialMemoryMb = 2000,
                JvmMaxMemoryMb = 3000,
                ClientMode = true
            };
        }

        /// <summary>
        /// BinaryObject approach does not require model classes, but is less efficient due to dynamic nature.
        /// </summary>
        [UsedImplicitly]
        private static void LoadCacheBinaryObjects(IIgnite ignite, RecordDescriptor desc, string dir)
        {
            var sw = Stopwatch.StartNew();
            long key = 0;

            var (reader, fullPath) = desc.GetInFileStream(dir);

            if (reader == null)
            {
                // File does not exist.
                return;
            }

            Console.WriteLine(fullPath);
            var cacheName = CreateCache(ignite, desc);

            using (reader)
            {
                var binary = ignite.GetBinary();

                using (var streamer = ignite.GetDataStreamer<long, object>(cacheName).WithKeepBinary<long, object>())
                {
                    while (true)
                    {
                        var builder = reader.ReadAsBinaryObject(cacheName, binary);

                        if (builder == null)
                        {
                            break;
                        }

                        var binaryObject = builder.Build();

                        // TODO: How do we determine proper primary key?
                        streamer.AddData(key++, binaryObject);
                    }
                }
            }

            var itemsPerSecond = key * 1000 / sw.ElapsedMilliseconds;
            Console.WriteLine($"Cache '{cacheName}' loaded in {sw.Elapsed}. {key} items, {itemsPerSecond} items/sec");
        }

        /// <summary>
        /// Uses model classes to load the cache.
        /// <see cref="ICanReadFromRecordBuffer"/> is the most efficient way to decode source data.
        /// <see cref="IBinarizable"/> is the most efficient way to pass data to Ignite.
        /// </summary>
        private static void LoadCacheGeneric<T>(IIgnite ignite, RecordDescriptor desc, string dir)
            where T : ICanReadFromRecordBuffer, new()
        {
            var log = LogManager.GetLogger(nameof(LoadCacheGeneric));

            try
            {
                var sw = Stopwatch.StartNew();
                long key = 0;

                var paths = desc.GetDataFilePaths(dir);

                if (!paths.Any())
                {
                    log.Error($"Failed to find data files for '{desc.InFile}' in directory '{dir}'.");
                }

                var cacheName = CreateCacheGeneric<T>(ignite, desc);

                foreach (var dataFilePath in paths)
                {
                    log.Info($"Starting {dataFilePath}...");

                    using (var reader = desc.GetBinaryRecordReader(dataFilePath))
                    using (var streamer = ignite.GetDataStreamer<long, T>(cacheName))
                    {
                        var buffer = new byte[desc.Length];

                        while (reader.Read(buffer))
                        {
                            var entity = new T();
                            entity.ReadFromRecordBuffer(buffer);

                            streamer.AddData(key++, entity);
                        }
                    }
                }

                var itemsPerSecond = key * 1000 / sw.ElapsedMilliseconds;
                log.Info($"Cache '{cacheName}' loaded in {sw.Elapsed}. {key} items, {itemsPerSecond} items/sec");
            }
            catch (Exception e)
            {
                log.Error(e, $"Failed to load {desc.InFile}");
            }
        }

        private static void InvokeLoadCacheGeneric(string dir, RecordDescriptor desc, IIgnite ignite)
        {
            // A bit of reflection won't hurt once per table.
            var typeName = "Apache.Ignite.Sybase.Ingest.Cache." + ModelClassGenerator.GetClassName(desc.TableName);
            var type = Type.GetType(typeName);

            if (type == null)
            {
                throw new Exception("Model class not found: " + typeName);
            }

            var method = typeof(CacheLoader)
                .GetMethod(nameof(LoadCacheGeneric), BindingFlags.Static | BindingFlags.NonPublic);

            var genericMethod = method.MakeGenericMethod(type);

            genericMethod.Invoke(null, new object[] {ignite, desc, dir});
        }

        private static string CreateCache(IIgnite ignite, RecordDescriptor desc)
        {
            // Create new cache (in case when query entities have changed).
            var cacheCfg = CacheConfigurator.GetQueryCacheConfiguration(desc);

            ignite.DestroyCache(cacheCfg.Name);
            ignite.CreateCache<long, object>(cacheCfg);

            return cacheCfg.Name;
        }

        private static string CreateCacheGeneric<T>(IIgnite ignite, RecordDescriptor desc)
        {
            // Create new cache (in case when query entities have changed).
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
                }
            };

            ignite.DestroyCache(cacheCfg.Name);
            ignite.CreateCache<long, T>(cacheCfg);

            return cacheCfg.Name;
        }
    }
}
