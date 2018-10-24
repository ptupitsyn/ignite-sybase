// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ModelClassTemplate : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField] public string FieldTemplate { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString(nameof(FieldTemplate), FieldTemplate);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            FieldTemplate = reader.ReadString(nameof(FieldTemplate));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                FieldTemplate = Encoding.ASCII.GetString(buffer, 0, 1).TrimEnd();
            }
        }
    }
}
