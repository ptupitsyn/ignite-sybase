// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ReclassWearersegment : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "wearersegment")] public long Wearersegment { get; set; }
        [QuerySqlField(Name = "awearseg")] public long Awearseg { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Wearersegment), Wearersegment);
            writer.WriteLong(nameof(Awearseg), Awearseg);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Wearersegment = reader.ReadLong(nameof(Wearersegment));
            Awearseg = reader.ReadLong(nameof(Awearseg));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Wearersegment = *(long*) (p + 0);
                Awearseg = *(long*) (p + 8);
            }
        }
    }
}
