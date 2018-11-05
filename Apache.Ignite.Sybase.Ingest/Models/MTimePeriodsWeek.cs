// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MTimePeriodsWeek : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "ppweek")] public long Ppweek { get; set; }
        [QuerySqlField(Name = "yearweek")] public long Yearweek { get; set; }
        [QuerySqlField(Name = "yearmonth")] public long Yearmonth { get; set; }
        [QuerySqlField(Name = "year")] public long Year { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "endofmonth")] public long Endofmonth { get; set; }
        [QuerySqlField(Name = "ppmonth")] public long Ppmonth { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("ppweek", Ppweek);
            writer.WriteLong("yearweek", Yearweek);
            writer.WriteLong("yearmonth", Yearmonth);
            writer.WriteLong("year", Year);
            writer.WriteString("description", Description);
            writer.WriteLong("endofmonth", Endofmonth);
            writer.WriteLong("ppmonth", Ppmonth);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppweek = reader.ReadLong("ppweek");
            Yearweek = reader.ReadLong("yearweek");
            Yearmonth = reader.ReadLong("yearmonth");
            Year = reader.ReadLong("year");
            Description = reader.ReadString("description");
            Endofmonth = reader.ReadLong("endofmonth");
            Ppmonth = reader.ReadLong("ppmonth");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Ppweek = *(long*) (p + 0);
                Yearweek = *(long*) (p + 8);
                Yearmonth = *(long*) (p + 16);
                Year = *(long*) (p + 24);
                Description = Encoding.ASCII.GetString(buffer, 32, 30).TrimEnd();
                Endofmonth = *(long*) (p + 62);
                Ppmonth = *(long*) (p + 70);
            }
        }
    }
}
