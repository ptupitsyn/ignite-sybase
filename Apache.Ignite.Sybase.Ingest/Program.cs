using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Discovery.Tcp;
using Apache.Ignite.Core.Discovery.Tcp.Static;
using Apache.Ignite.Sybase.Ingest.Cache;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;
using JetBrains.Annotations;

namespace Apache.Ignite.Sybase.Ingest
{
    static class Program
    {
        static void Main(string[] args)
        {
            // We should saturate CPU, Network, and Disk for best perf.
            // Ideally producer/consumer with back-pressure is required: load data from disk and parse, pass to Streamer.
            // For simplicity let's just have single-threaded method to load single table, then run in parallel for multiple tables.

            // Records are fixed length. Only 3 data types are used across all tables:
            // STRING
            // INTEGER(8)
            // DOUBLE

            var dir = Path.GetFullPath(args?.FirstOrDefault() ?? @"..\..\data");

            // Tests.TestReadAllData(dir);
            // GenerateModels(dir);
            LoadIgnite(dir);
        }

        private static void LoadIgnite(string dir)
        {
            var cfg = new IgniteConfiguration
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

            var ignite = Ignition.Start(cfg);
            var recordDescriptors = Tests.GetRecordDescriptors(dir).Take(30);

            var sw = Stopwatch.StartNew();

            Parallel.ForEach(recordDescriptors, desc =>
            {
                // A bit of reflection won't hurt once per table.
                var typeName = "Apache.Ignite.Sybase.Ingest.Cache." + ModelClassGenerator.GetClassName(desc.TableName);
                var type = Type.GetType(typeName);
                var method = typeof(Program).GetMethod(nameof(LoadCacheGeneric),
                    BindingFlags.Static | BindingFlags.NonPublic);
                var genericMethod = method.MakeGenericMethod(type);

                genericMethod.Invoke(null, new object[] {ignite, desc, dir});
            });

            var elapsed = sw.Elapsed;

            var cacheNames = ignite.GetCacheNames();
            var totalItems = cacheNames.Sum(n => ignite.GetCache<int, int>(n).GetSize());

            Console.WriteLine("\n==========================");
            Console.WriteLine("Loading complete:");
            Console.WriteLine($" * {cacheNames.Count} caches");
            Console.WriteLine($" * {totalItems} cache entries");
            Console.WriteLine($" * {elapsed} elapsed, {totalItems / elapsed.TotalSeconds} entries per second.");
            Console.ReadKey();
        }

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

        private static void LoadCacheGeneric<T>(IIgnite ignite, RecordDescriptor desc, string dir)
            where T : ICanReadFromRecordBuffer, new()
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
            var cacheName = CreateCacheGeneric<T>(ignite, desc);

            using (reader)
            {
                var buffer = new byte[desc.Length];

                using (var streamer = ignite.GetDataStreamer<long, T>(cacheName))
                {
                    while (true)
                    {
                        if (!reader.Read(buffer))
                        {
                            break;
                        }

                        var entity = new T();
                        entity.ReadFromRecordBuffer(buffer);;

                        streamer.AddData(key++, entity);
                    }
                }
            }

            var itemsPerSecond = key * 1000 / sw.ElapsedMilliseconds;
            Console.WriteLine($"Cache '{cacheName}' loaded in {sw.Elapsed}. {key} items, {itemsPerSecond} items/sec");
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

        [UsedImplicitly]
        private static void GenerateModels(string dir)
        {
            var recordDescriptors = Tests.GetRecordDescriptors(dir);

            foreach (var desc in recordDescriptors)
            {
                ModelClassGenerator.GenerateClass(desc);
            }
        }
    }
}
