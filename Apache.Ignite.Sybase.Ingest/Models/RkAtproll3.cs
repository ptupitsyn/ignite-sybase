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
            writer.WriteLong(nameof(Calendarmonth), Calendarmonth);
            writer.WriteLong(nameof(Atproll3), Atproll3);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Calendarmonth = reader.ReadLong(nameof(Calendarmonth));
            Atproll3 = reader.ReadLong(nameof(Atproll3));
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
