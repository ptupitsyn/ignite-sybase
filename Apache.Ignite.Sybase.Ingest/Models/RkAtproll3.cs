// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class RkAtproll3 : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "calendarmonth")] public long Calendarmonth { get; set; }
        [QuerySqlField(Name = "atproll3")] public long Atproll3 { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("calendarmonth", Calendarmonth);
            writer.WriteLong("atproll3", Atproll3);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Calendarmonth = reader.ReadLong("calendarmonth");
            Atproll3 = reader.ReadLong("atproll3");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Calendarmonth = *(long*) (p + 0);
                Atproll3 = *(long*) (p + 8);
            }
        }
    }
}
