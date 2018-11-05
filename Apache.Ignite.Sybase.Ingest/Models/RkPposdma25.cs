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
            writer.WriteLong("dma", Dma);
            writer.WriteLong("pposdma25", Pposdma25);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Dma = reader.ReadLong("dma");
            Pposdma25 = reader.ReadLong("pposdma25");
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
