// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class RkAtpytd : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "calendarmonth")] public long Calendarmonth { get; set; }
        [QuerySqlField(Name = "atpytd")] public long Atpytd { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("calendarmonth", Calendarmonth);
            writer.WriteLong("atpytd", Atpytd);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Calendarmonth = reader.ReadLong("calendarmonth");
            Atpytd = reader.ReadLong("atpytd");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Calendarmonth = *(long*) (p + 0);
                Atpytd = *(long*) (p + 8);
            }
        }
    }
}
