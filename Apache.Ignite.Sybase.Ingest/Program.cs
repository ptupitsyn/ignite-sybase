using System;
using System.IO;
using System.Linq;

namespace Apache.Ignite.Sybase.Ingest
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: We should saturate CPU, Network, and Disk for best perf.
            // Ideally producer/consumer with back-pressure is required: load data from disk and parse, pass to Streamer.
            // For simplicity let's just have single-threaded method to load single table, then run in parallel for multiple tables.

            ParseCtls();
        }

        private static void ParseDdls()
        {
            var dir = Path.GetFullPath(@"..\..\data\ddl");
            var ddlFiles = Directory.GetFiles(dir);

            Console.WriteLine($"Found {ddlFiles.Length} DDL files.");

            var tables = ddlFiles
                .Select(DdlParser.ParseDdl)
                .Where(t => t != null)
                .ToArray();

            foreach (var table in tables)
            {
                Console.WriteLine(
                    $"{table.Name} ({string.Join(", ", table.Columns.Select(c => $"{c.Name}:{c.SqlType}_{c.SqlTypeQualifier}"))})");
            }

            Console.WriteLine("\nDistinct SQL data types:");

            var dataTypes = tables
                .SelectMany(t => t.Columns)
                .Select(c => $"{c.SqlType}_{c.SqlTypeQualifier}")
                .Distinct();

            Console.WriteLine(string.Join("\n", dataTypes));
        }

        private static void ParseCtls()
        {
            var dir = Path.GetFullPath(@"..\..\data\load_script");
            var ctlFiles = Directory.GetFiles(dir, "*.ctl");

            Console.WriteLine($"Found {ctlFiles.Length} CTL files.");

            var recordDescriptors = ctlFiles
                .Select(CtlParser.ParseCtl)
                .Where(t => t != null)
                .ToArray();

            foreach (var recordDescriptor in recordDescriptors)
            {
                Console.WriteLine(recordDescriptor);
            }

            Console.WriteLine("\nDistinct SQL data types:");

            var dataTypes = recordDescriptors
                .SelectMany(t => t.Fields)
                .Select(c => c.Type)
                .Distinct();

            Console.WriteLine(string.Join("\n", dataTypes));
        }
    }
}
