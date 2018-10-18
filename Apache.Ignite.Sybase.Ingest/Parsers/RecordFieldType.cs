namespace Apache.Ignite.Sybase.Ingest.Parsers
{
    /// <summary>
    /// Actual data only uses 3 types:
    /// STRING
    /// INTEGER(8)
    /// DOUBLE
    /// </summary>
    public enum RecordFieldType
    {
        String,
        Long,
        Double
    }
}
