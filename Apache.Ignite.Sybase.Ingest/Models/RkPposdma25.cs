// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class RkPposdma25 : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "dma")] public long Dma { get; set; }
        [QuerySqlField(Name = "pposdma25")] public long Pposdma25 { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Dma), Dma);
            writer.WriteLong(nameof(Pposdma25), Pposdma25);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Dma = reader.ReadLong(nameof(Dma));
            Pposdma25 = reader.ReadLong(nameof(Pposdma25));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Dma = *(long*) (p + 0);
                Pposdma25 = *(long*) (p + 8);
            }
        }
    }
}
