using System;

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
    }
}
