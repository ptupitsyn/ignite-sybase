using System;
using Apache.Ignite.Sybase.Ingest.Common;

namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    public class RecordField
    {
        public RecordField(string name, string typeName, int startPos, int endPos)
        {
            Name = Arg.NotNullOrWhitespace(name, nameof(name));
            TypeName = typeName;
            StartPos = Arg.InRange(startPos, 0, int.MaxValue, nameof(startPos));
            EndPos = Arg.InRange(endPos, startPos + 1, int.MaxValue, nameof(endPos));

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

        /// <summary>
        /// 1 - based start position.
        /// </summary>
        public int StartPos { get; }

        /// <summary>
        /// End position.
        /// </summary>
        public int EndPos { get; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(TypeName)}: {TypeName}, {nameof(StartPos)}: {StartPos}, {nameof(EndPos)}: {EndPos}";
        }
    }
}
