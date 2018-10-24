// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class RkAtpannu1 : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "calendarmonth")] public long Calendarmonth { get; set; }
        [QuerySqlField(Name = "atpannu1")] public long Atpannu1 { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Calendarmonth), Calendarmonth);
            writer.WriteLong(nameof(Atpannu1), Atpannu1);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Calendarmonth = reader.ReadLong(nameof(Calendarmonth));
            Atpannu1 = reader.ReadLong(nameof(Atpannu1));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Calendarmonth = *(long*) (p + 0);
                Atpannu1 = *(long*) (p + 8);
            }
        }
    }
}
