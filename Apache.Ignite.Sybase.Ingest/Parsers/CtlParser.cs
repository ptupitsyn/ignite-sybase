using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    /// <summary>
    /// Parses CTL files.
    /// TODO: We can parse ctrl.gen files instead, they are simpler (CSV). But I missed that part, so here goes.
    /// </summary>
    public static class CtlParser
    {
        private const string TokenIntoTable = "Into table";
        private const string TokenInfile = "INFILE";
        private const string TokenPosition = "position(";

        public static RecordDescriptor Parse(string path)
        {
            var lines = File.ReadAllLines(path);
            var inFile = string.Empty;
            var tableName = string.Empty;
            var length = 0;
            var fields = new List<RecordField>();

            foreach (var line in lines)
            {
                if (line.StartsWith(TokenInfile, StringComparison.Ordinal))
                {
                    var parts = line.Split(new[] {"'", "\""}, StringSplitOptions.RemoveEmptyEntries)
                        .Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

                    if (parts.Length != 3)
                    {
                        throw new Exception("Failed to parse INFILE: " + line);
                    }

                    inFile = parts[1];
                    length = int.Parse(parts[2].Split(" ")[1]);

                    continue;
                }

                if (line.StartsWith(TokenIntoTable, StringComparison.InvariantCultureIgnoreCase))
                {
                    tableName = line
                        .Substring(TokenIntoTable.Length)
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .First();

                    continue;
                }

                // Fields section is last.
                if (!string.IsNullOrEmpty(tableName) && line.Length > 2)
                {
                    fields.Add(ParseField(line));
                }
            }

            return fields.Any() && length > 0
                ? new RecordDescriptor(length, fields, inFile, tableName)
                : null;
        }

        private static RecordField ParseField(string line)
        {
            var parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2 || !parts[1].StartsWith(TokenPosition))
            {
                throw new Exception("Failed to parse field: " + line);
            }

            var posParts = parts[1].Split(new[] {"(", ":", ")"}, StringSplitOptions.RemoveEmptyEntries);

            if (posParts.Length < 3)
            {
                throw new Exception("Failed to parse field: " + line);
            }

            return new RecordField(
                parts[0],
                parts.Length > 2 ? parts[2].Trim(',') : null,
                int.Parse(posParts[1]),
                int.Parse(posParts[2]));
        }
    }
}
