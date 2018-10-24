// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ModelClassTemplate : IBinarizable
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
            const int pos = 0;
            const int len = 256;
            FieldTemplate = Encoding.ASCII.GetString(buffer, pos, len).TrimEnd();
        }
    }
}
