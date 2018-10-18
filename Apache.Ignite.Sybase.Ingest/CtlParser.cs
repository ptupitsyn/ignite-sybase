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
            }


            return fields.Any() && length > 0
                ? new RecordDescriptor(length, fields, inFile, tableName)
                : null;
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
    }

    public class RecordField
    {
        public int Length { get; }

        public string TypeName { get; }
    }

    public enum RecordFieldType
    {
        None,
        String,
    }
}
