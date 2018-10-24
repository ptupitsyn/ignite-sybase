using System;
using Apache.Ignite.Core.Binary;

namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    public static class RecordFieldTypeExtensions
    {
        public static Type GetClrType(this RecordFieldType fieldType)
        {
            switch (fieldType)
            {
                case RecordFieldType.String:
                    return typeof(string);

                case RecordFieldType.Long:
                    return typeof(long);

                case RecordFieldType.Double:
                    return typeof(double);

                default:
                    throw new ArgumentOutOfRangeException(nameof(fieldType), fieldType, null);
            }
        }

        public static string GetShortTypeName(this RecordFieldType fieldType)
        {
            switch (fieldType)
            {
                case RecordFieldType.String:
                    return "string";

                case RecordFieldType.Long:
                    return "long";

                case RecordFieldType.Double:
                    return "double";

                default:
                    throw new ArgumentOutOfRangeException(nameof(fieldType), fieldType, null);
            }
        }

        public static string GetWriteMethodName(this RecordFieldType fieldType)
        {
            switch (fieldType)
            {
                case RecordFieldType.String:
                    return nameof(IBinaryWriter.WriteString);

                case RecordFieldType.Long:
                    return nameof(IBinaryWriter.WriteLong);

                case RecordFieldType.Double:
                    return nameof(IBinaryWriter.WriteDouble);

                default:
                    throw new ArgumentOutOfRangeException(nameof(fieldType), fieldType, null);
            }
        }

        public static string GetReadMethodName(this RecordFieldType fieldType)
        {
            switch (fieldType)
            {
                case RecordFieldType.String:
                    return nameof(IBinaryReader.ReadString);

                case RecordFieldType.Long:
                    return nameof(IBinaryReader.ReadLong);

                case RecordFieldType.Double:
                    return nameof(IBinaryReader.ReadDouble);

                default:
                    throw new ArgumentOutOfRangeException(nameof(fieldType), fieldType, null);
            }
        }
    }
}
