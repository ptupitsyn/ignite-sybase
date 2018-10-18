using System;
using System.Collections.Generic;
using System.IO;

namespace Apache.Ignite.Sybase.Ingest
{
    public static class CtlParser
    {
        public static RecordDescriptor ParseCtl(string path)
        {
            var lines = File.ReadAllLines(path);
            string inFile;
            int length;

            foreach (var line in lines)
            {
                if (line.StartsWith("INFILE", StringComparison.Ordinal))
                {
                    var parts = line.Split(new[] {"'", "\""}, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length != 3)
                    {
                        throw new Exception("Failed to parse INFILE: " + line);
                    }

                    inFile = parts[1];
                    length = int.Parse(parts[2].Split(" ")[1]);
                }
            }
        }
    }

    public class RecordDescriptor
    {
        public RecordDescriptor(int length, IReadOnlyCollection<RecordField> fields, string inFile)
        {
            Length = length;
            Fields = fields;
            InFile = inFile;
        }

        public int Length { get; }

        public string InFile { get; }

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
