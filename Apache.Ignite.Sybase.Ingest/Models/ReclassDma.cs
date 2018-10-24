// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ReclassDma : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "dma")] public long Dma { get; set; }
        [QuerySqlField(Name = "awalmartcma")] public long Awalmartcma { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Dma), Dma);
            writer.WriteLong(nameof(Awalmartcma), Awalmartcma);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Dma = reader.ReadLong(nameof(Dma));
            Awalmartcma = reader.ReadLong(nameof(Awalmartcma));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Dma = *(long*) (p + 0);
                Awalmartcma = *(long*) (p + 8);
            }
        }
    }
}
