using System;

namespace Apache.Ignite.Sybase.Ingest
{
    public class RecordField
    {
        public RecordField(string name, string typeName, int position, int length)
        {
            Name = name;
            TypeName = typeName;
            Position = position;
            Length = length;

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
