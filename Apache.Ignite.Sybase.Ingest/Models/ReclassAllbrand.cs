// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ReclassAllbrand : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "allbrand")] public long Allbrand { get; set; }
        [QuerySqlField(Name = "adjwcensusbrands")] public long Adjwcensusbrands { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("allbrand", Allbrand);
            writer.WriteLong("adjwcensusbrands", Adjwcensusbrands);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Allbrand = reader.ReadLong("allbrand");
            Adjwcensusbrands = reader.ReadLong("adjwcensusbrands");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Allbrand = *(long*) (p + 0);
                Adjwcensusbrands = *(long*) (p + 8);
            }
        }
    }
}
