using System.Collections.Generic;
using Apache.Ignite.Sybase.Ingest.Common;

namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    public class RecordDescriptor
    {
        public RecordDescriptor(int length, IReadOnlyList<RecordField> fields, string inFile, string tableName)
        {
            Length = Arg.InRange(length, 1, int.MaxValue, nameof(length));
            Fields = Arg.NotNullOrEmpty(fields, nameof(fields));
            InFile = Arg.NotNullOrWhitespace(inFile, nameof(inFile));
            TableName = Arg.NotNullOrWhitespace(tableName, nameof(tableName));
        }

        public int Length { get; }

        public string InFile { get; }

        public string TableName { get; }

        public IReadOnlyList<RecordField> Fields { get; }

        public override string ToString()
        {
            return $"{nameof(Length)}: {Length}, {nameof(InFile)}: {InFile}, {nameof(TableName)}: {TableName}";
        }
    }
}
