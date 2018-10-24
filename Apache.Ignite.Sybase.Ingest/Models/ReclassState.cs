// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ReclassState : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "state")] public long State { get; set; }
        [QuerySqlField(Name = "cpmstater")] public long Cpmstater { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(State), State);
            writer.WriteLong(nameof(Cpmstater), Cpmstater);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            State = reader.ReadLong(nameof(State));
            Cpmstater = reader.ReadLong(nameof(Cpmstater));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                State = *(long*) (p + 0);
                Cpmstater = *(long*) (p + 8);
            }
        }
    }
}
