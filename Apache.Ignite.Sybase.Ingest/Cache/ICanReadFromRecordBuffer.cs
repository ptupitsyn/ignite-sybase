namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public interface ICanReadFromRecordBuffer
    {
        void ReadFromRecordBuffer(byte[] buffer);
    }
}
