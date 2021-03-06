// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class RkAtpseasn : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "calendarmonth")] public long Calendarmonth { get; set; }
        [QuerySqlField(Name = "atpseasn")] public long Atpseasn { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("calendarmonth", Calendarmonth);
            writer.WriteLong("atpseasn", Atpseasn);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Calendarmonth = reader.ReadLong("calendarmonth");
            Atpseasn = reader.ReadLong("atpseasn");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Calendarmonth = *(long*) (p + 0);
                Atpseasn = *(long*) (p + 8);
            }
        }
    }
}
