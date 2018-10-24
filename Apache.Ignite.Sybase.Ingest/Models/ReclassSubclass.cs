// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ReclassSubclass : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "cyexclude")] public long Cyexclude { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Subclass), Subclass);
            writer.WriteLong(nameof(Cyexclude), Cyexclude);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Subclass = reader.ReadLong(nameof(Subclass));
            Cyexclude = reader.ReadLong(nameof(Cyexclude));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Subclass = *(long*) (p + 0);
                Cyexclude = *(long*) (p + 8);
            }
        }
    }
}
