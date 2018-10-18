using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Apache.Ignite.Sybase.Ingest
{
    public static class CtlParser
    {
        private const string TokenIntoTable = "Into table";
        private const string TokenInfile = "INFILE";
        private const string TokenPosition = "position(";

        public static RecordDescriptor ParseCtl(string path)
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
                    var parts = line.Split(new[] {"'", "\""}, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length != 3)
                    {
                        throw new Exception("Failed to parse INFILE: " + line);
                    }

                    inFile = parts[1];
                    length = int.Parse(parts[2].Split(" ")[1]);
                }

                if (line.StartsWith(TokenIntoTable, StringComparison.InvariantCultureIgnoreCase))
                {
                    tableName = line
                        .Substring(TokenInfile.Length)
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .First();
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

            var posParts = parts[1].Split(new[] {"(", ":"}, StringSplitOptions.RemoveEmptyEntries);

            if (posParts.Length != 3)
            {
                throw new Exception("Failed to parse field: " + line);
            }

            return new RecordField(
                parts[0],
                parts.Length > 2 ? parts[2] : null,
                int.Parse(posParts[1]),
                int.Parse(posParts[2]));
        }
    }

    public class RecordDescriptor
    {
        public RecordDescriptor(int length, IReadOnlyCollection<RecordField> fields, string inFile, string tableName)
        {
            Length = length;
            Fields = fields;
            InFile = inFile;
            TableName = tableName;
        }

        public int Length { get; }

        public string InFile { get; }

        public string TableName { get; }

        public IReadOnlyCollection<RecordField> Fields { get; }

        public override string ToString()
        {
            return $"{nameof(Length)}: {Length}, {nameof(InFile)}: {InFile}, {nameof(TableName)}: {TableName}";
        }
    }

    public class RecordField
    {
        public RecordField(string name, string typeName, int position, int length)
        {
            Name = name;
            TypeName = typeName;
            Position = position;
            Length = length;
        }

        public string Name { get; }

        public string TypeName { get; }

        public int Position { get; }

        public int Length { get; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(TypeName)}: {TypeName}, {nameof(Position)}: {Position}, {nameof(Length)}: {Length}";
        }
    }

    public enum RecordFieldType
    {
        None,
        String,
    }
}
