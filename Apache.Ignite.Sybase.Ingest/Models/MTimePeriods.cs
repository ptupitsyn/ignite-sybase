// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MTimePeriods : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "ppmonth")] public long Ppmonth { get; set; }
        [QuerySqlField(Name = "ppweek")] public long Ppweek { get; set; }
        [QuerySqlField(Name = "year")] public long Year { get; set; }
        [QuerySqlField(Name = "yearhalf")] public long Yearhalf { get; set; }
        [QuerySqlField(Name = "yearqtr")] public long Yearqtr { get; set; }
        [QuerySqlField(Name = "year_desc")] public string YearDesc { get; set; }
        [QuerySqlField(Name = "yearhalf_desc")] public string YearhalfDesc { get; set; }
        [QuerySqlField(Name = "yearqtr_desc")] public string YearqtrDesc { get; set; }
        [QuerySqlField(Name = "yearmonth")] public long Yearmonth { get; set; }
        [QuerySqlField(Name = "yearmonth_desc")] public string YearmonthDesc { get; set; }
        [QuerySqlField(Name = "yearweek_desc")] public string YearweekDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("ppmonth", Ppmonth);
            writer.WriteLong("ppweek", Ppweek);
            writer.WriteLong("year", Year);
            writer.WriteLong("yearhalf", Yearhalf);
            writer.WriteLong("yearqtr", Yearqtr);
            writer.WriteString("year_desc", YearDesc);
            writer.WriteString("yearhalf_desc", YearhalfDesc);
            writer.WriteString("yearqtr_desc", YearqtrDesc);
            writer.WriteLong("yearmonth", Yearmonth);
            writer.WriteString("yearmonth_desc", YearmonthDesc);
            writer.WriteString("yearweek_desc", YearweekDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppmonth = reader.ReadLong("ppmonth");
            Ppweek = reader.ReadLong("ppweek");
            Year = reader.ReadLong("year");
            Yearhalf = reader.ReadLong("yearhalf");
            Yearqtr = reader.ReadLong("yearqtr");
            YearDesc = reader.ReadString("year_desc");
            YearhalfDesc = reader.ReadString("yearhalf_desc");
            YearqtrDesc = reader.ReadString("yearqtr_desc");
            Yearmonth = reader.ReadLong("yearmonth");
            YearmonthDesc = reader.ReadString("yearmonth_desc");
            YearweekDesc = reader.ReadString("yearweek_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Ppmonth = *(long*) (p + 0);
                Ppweek = *(long*) (p + 8);
                Year = *(long*) (p + 16);
                Yearhalf = *(long*) (p + 24);
                Yearqtr = *(long*) (p + 32);
                YearDesc = Encoding.ASCII.GetString(buffer, 40, 4).TrimEnd();
                YearhalfDesc = Encoding.ASCII.GetString(buffer, 44, 7).TrimEnd();
                YearqtrDesc = Encoding.ASCII.GetString(buffer, 51, 7).TrimEnd();
                Yearmonth = *(long*) (p + 58);
                YearmonthDesc = Encoding.ASCII.GetString(buffer, 66, 10).TrimEnd();
                YearweekDesc = Encoding.ASCII.GetString(buffer, 76, 30).TrimEnd();
            }
        }
    }
}
