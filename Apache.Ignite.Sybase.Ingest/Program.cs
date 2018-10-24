using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Discovery.Tcp;
using Apache.Ignite.Core.Discovery.Tcp.Static;
using Apache.Ignite.Sybase.Ingest.Cache;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;

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
                        Endpoints = new[] {"127.0.0.1:47500"}
                    },
                    SocketTimeout = TimeSpan.FromSeconds(0.3)
                },
                // 2.4 works?
                // 2.5-2.7 crashes, only when these values are specified.
                JvmInitialMemoryMb = 2000,
                JvmMaxMemoryMb = 3000

            };

            var ignite = Ignition.Start(cfg);
            var recordDescriptors = Tests.GetRecordDescriptors(dir).Take(3);

            var sw = Stopwatch.StartNew();
            Parallel.ForEach(recordDescriptors, desc => LoadCache(ignite, desc, dir));
            var elapsed = sw.Elapsed;

            var cacheNames = ignite.GetCacheNames();
            var totalItems = cacheNames.Sum(n => ignite.GetCache<int, int>(n).GetSize());

            Console.WriteLine("\n==========================");
            Console.WriteLine("Loading complete:");
            Console.WriteLine($" * {cacheNames.Count} caches");
            Console.WriteLine($" * {totalItems} cache entries");
            Console.WriteLine($" * {elapsed} elapsed, {totalItems / elapsed.TotalSeconds} entries per second.");
        }

        private static void LoadCache(IIgnite ignite, RecordDescriptor desc, string dir)
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

        private static string CreateCache(IIgnite ignite, RecordDescriptor desc)
        {
            // Create new cache (in case when query entities have changed).
            var cacheCfg = CacheConfigurator.GetQueryCacheConfiguration(desc);

            ignite.DestroyCache(cacheCfg.Name);
            ignite.CreateCache<long, object>(cacheCfg);

            return cacheCfg.Name;
        }
    }
}
