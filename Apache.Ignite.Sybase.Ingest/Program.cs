using System;
using System.IO;
using System.Linq;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Discovery.Tcp;
using Apache.Ignite.Core.Discovery.Tcp.Static;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;

namespace Apache.Ignite.Sybase.Ingest
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: We should saturate CPU, Network, and Disk for best perf.
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
                }
            };

            using (var ignite = Ignition.Start(cfg))
            {
                var recordDescriptors = Tests.GetRecordDescriptors(dir);
                foreach (var desc in recordDescriptors)
                {
                    LoadCache(ignite, desc, dir);
                }
            }
        }

        private static void LoadCache(IIgnite ignite, RecordDescriptor desc, string dir)
        {
            var (reader, fullPath) = desc.GetInFileStream(dir);

            if (reader == null)
            {
                // File does not exist.
                return;
            }

            using (reader)
            {
                var cacheName = desc.TableName;
                ignite.GetOrCreateCache<long, object>(cacheName);
                var binary = ignite.GetBinary();

                Console.WriteLine(fullPath);

                // TODO: How do we determine proper primary key?
                long key = 0;

                using (var streamer = ignite.GetDataStreamer<long, object>(cacheName).WithKeepBinary<long, object>())
                {
                    // Read top 3 records for demo.
                    while (true)
                    {
                        var rec = reader.ReadAsBinaryObject(cacheName, binary);

                        if (rec == null)
                        {
                            break;
                        }

                        streamer.AddData(key++, rec.Build());
                    }
                }
            }
        }
    }
}
