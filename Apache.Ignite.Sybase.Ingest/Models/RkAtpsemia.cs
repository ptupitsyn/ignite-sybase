// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class RkAtpsemia : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "calendarmonth")] public long Calendarmonth { get; set; }
        [QuerySqlField(Name = "atpsemia")] public long Atpsemia { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("calendarmonth", Calendarmonth);
            writer.WriteLong("atpsemia", Atpsemia);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Calendarmonth = reader.ReadLong("calendarmonth");
            Atpsemia = reader.ReadLong("atpsemia");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Calendarmonth = *(long*) (p + 0);
                Atpsemia = *(long*) (p + 8);
            }
        }
    }
}
