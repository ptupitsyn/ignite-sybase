using System;
using System.IO;
using System.Linq;
using Apache.Ignite.Sybase.Ingest.Cache;
using Apache.Ignite.Sybase.Ingest.Common;
using Apache.Ignite.Sybase.Ingest.Parsers;

namespace Apache.Ignite.Sybase.Ingest
{
    public static class Tests
    {
        public static void TestParseDdls(string dir)
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

        public static void TestParseCtls(string dir)
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

        public static void TestReadFactPostdataMon(string dir)
        {
            var recordDescriptors = CtrlGenParser.ParseAll(dir)
                .OrderBy(d => d.InFile)
                .ToArray();

            var recordDescriptor = recordDescriptors.Single(d => d.TableName.EndsWith("fact_posdata_mon"));
            var path = recordDescriptor.GetDataFilePaths(dir).First();

            using (var reader = recordDescriptor.GetBinaryRecordReader(path))
            {
                var buf = new byte[recordDescriptor.Length];

                // Read top 3 records for demo.
                for (var i = 0; i < 3; i++)
                {
                    reader.Read(buf);

                    var model = new FactPosdataMon();
                    model.ReadFromRecordBuffer(buf);

                    Console.WriteLine(model);
                }
            }
        }

        public static void TestReadAllData(string dir)
        {
            var recordDescriptors = GetRecordDescriptors(dir);

            foreach (var recordDescriptor in recordDescriptors)
            {
                var (reader, fullPath) = recordDescriptor.GetInFileStream(dir);

                if (reader == null)
                {
                    continue;
                }

                Console.WriteLine(fullPath);

                using (reader)
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

        public static RecordDescriptor[] GetRecordDescriptors(string dir)
        {
            var ctlFiles = Directory.GetFiles(Path.Combine(dir, "load_script"), "*.ctl");

            return ctlFiles
                .Select(CtlParser.Parse)
                .Where(t => t != null)
                .ToArray();
        }
    }
}
