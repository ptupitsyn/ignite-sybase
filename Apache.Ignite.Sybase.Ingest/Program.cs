using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;
using Apache.Ignite.Sybase.Ingest.Loaders;
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

            TestReadAllData(dir);
        }

        private static void TestParseDdls(string dir)
        {
            var ddlFiles = Directory.GetFiles(Path.Combine(dir, "ddl"));

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

        private static void TestParseCtls(string dir)
        {
            var recordDescriptors = GetRecordDescriptors(dir);

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

        private static void TestReadAllData(string dir)
        {
            var recordDescriptors = GetRecordDescriptors(dir);

            foreach (var recordDescriptor in recordDescriptors)
            {
                var fileName = recordDescriptor.InFile.Split(
                    new[] {Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar},
                    StringSplitOptions.RemoveEmptyEntries)
                    .Last();

                var fullPath = Path.Combine(dir, fileName + ".gz");

                if (!File.Exists(fullPath))
                {
                    continue;
                }

                Console.WriteLine(fullPath);

                using (var fileStream = File.OpenRead(fullPath))
                using (var gzipStream = new GZipStream(fileStream, CompressionMode.Decompress))
                using (var reader = new BinaryRecordReader(recordDescriptor, gzipStream))
                {
                    // Read top 3 records for demo.
                    for (var i = 0; i < 3; i++)
                    {
                        var rec = reader.Read();

                        if (rec == null)
                        {
                            break;
                        }

                        for (var index = 0; index < recordDescriptor.Fields.Count; index++)
                        {
                            var field = recordDescriptor.Fields[index];
                            var val = rec[index];
                            Console.Write($"{field.Name}: {val}; ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }

        private static RecordDescriptor[] GetRecordDescriptors(string dir)
        {
            var ctlFiles = Directory.GetFiles(Path.Combine(dir, "load_script"), "*.ctl");

            return ctlFiles
                .Select(CtlParser.ParseCtl)
                .Where(t => t != null)
                .ToArray();
        }
    }
}
