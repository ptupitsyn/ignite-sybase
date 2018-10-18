namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    public class ColumnDefinition
    {
        public ColumnDefinition(string name, string sqlType, string sqlTypeQualifier)
        {
            Name = name;
            SqlType = sqlType;
            SqlTypeQualifier = sqlTypeQualifier;
        }

        public string Name { get;  }
        public string SqlType { get; }
        public string SqlTypeQualifier { get; }
    }
}
