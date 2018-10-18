using System.Collections.Generic;

namespace Apache.Ignite.Sybase.Ingest
{
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
}