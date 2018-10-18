using System;
using Apache.Ignite.Sybase.Ingest.Common;

namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    public class RecordField
    {
        public RecordField(string name, string typeName, int position, int length)
        {
            Name = Arg.NotNullOrWhitespace(name, nameof(name));
            TypeName = Arg.NotNullOrWhitespace(typeName, nameof(typeName));
            Position = Arg.InRange(position, 0, int.MaxValue, nameof(position));
            Length = Arg.InRange(length, 1, int.MaxValue, nameof(length));

            switch (typeName)
            {
                case null:
                    Type = RecordFieldType.String;
                    break;
                case "INTEGER(8)":
                    Type = RecordFieldType.Long;
                    break;
                case "DOUBLE":
                    Type = RecordFieldType.Double;
                    break;
                default:
                    throw new Exception("Unexpected field type: " + typeName);
            }
        }

        public string Name { get; }

        public string TypeName { get; }

        public RecordFieldType Type { get; }

        public int Position { get; }

        public int Length { get; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(TypeName)}: {TypeName}, {nameof(Position)}: {Position}, {nameof(Length)}: {Length}";
        }
    }
}
