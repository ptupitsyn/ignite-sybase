// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class RkAtpqtrs : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "calendarmonth")] public long Calendarmonth { get; set; }
        [QuerySqlField(Name = "atpqtrs")] public long Atpqtrs { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Calendarmonth), Calendarmonth);
            writer.WriteLong(nameof(Atpqtrs), Atpqtrs);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Calendarmonth = reader.ReadLong(nameof(Calendarmonth));
            Atpqtrs = reader.ReadLong(nameof(Atpqtrs));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Calendarmonth = *(long*) (p + 0);
                Atpqtrs = *(long*) (p + 8);
            }
        }
    }
}
