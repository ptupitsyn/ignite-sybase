using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Apache.Ignite.Sybase.Ingest
{
    class Program
    {
        private static readonly Regex TableRegex = new Regex(@"create table (.*?) \(", RegexOptions.Compiled);

        static void Main(string[] args)
        {
            // TODO: We should saturate CPU, Network, and Disk for best perf.
            // Ideally producer/consumer with back-pressure is required: load data from disk and parse, pass to Streamer.
            // For simplicity let's just have single-threaded method to load single table, then run in parallel for multiple tables.

            var dir = Path.GetFullPath(@"..\..\data\ddl");
            var ddlFiles = Directory.GetFiles(dir);

            Console.WriteLine($"Found {ddlFiles.Length} DDL files.");

            foreach (var file in ddlFiles)
            {
                var tableDef = ParseDdl(file);

                if (tableDef != null)
                {
                    Console.WriteLine($"{tableDef.Name} ({string.Join(", ", tableDef.Columns.Select(c => $"{c.Name}:{c.SqlType}"))})");
                }
            }
        }

        private static TableDefinition ParseDdl(string path)
        {
            var text = File
                .ReadAllLines(path)
                .Where(l => !l.StartsWith("-"))
                .TakeWhile(l => !l.EndsWith(";"))
                .ToList();

            var tableName = TableRegex.Match(text[0]).Groups[1].Value;

            if (string.IsNullOrWhiteSpace(tableName))
            {
                return null;
            }

            var columns = text
                .Skip(1)
                .Select(l =>
                {
                    var parts = l.Split(new[] {" ", "("}, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != 3)
                    {
                        return null;
                    }

                    return new ColumnDefinition(parts[0], parts[1]);
                })
                .Where(c => c != null)
                .ToList();

            return new TableDefinition(tableName, columns);
        }
    }

    class TableDefinition
    {
        public TableDefinition(string name, IReadOnlyList<ColumnDefinition> columns)
        {
            Name = name;
            Columns = columns;
        }

        public string Name { get; }

        public IReadOnlyList<ColumnDefinition> Columns { get; }
    }

    class ColumnDefinition
    {
        public ColumnDefinition(string name, string sqlType)
        {
            Name = name;
            SqlType = sqlType;
        }

        public string Name { get;  }
        public string SqlType { get; }
    }
}
