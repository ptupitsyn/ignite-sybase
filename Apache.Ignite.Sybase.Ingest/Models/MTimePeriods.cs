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
            writer.WriteLong(nameof(Ppmonth), Ppmonth);
            writer.WriteLong(nameof(Ppweek), Ppweek);
            writer.WriteLong(nameof(Year), Year);
            writer.WriteLong(nameof(Yearhalf), Yearhalf);
            writer.WriteLong(nameof(Yearqtr), Yearqtr);
            writer.WriteString(nameof(YearDesc), YearDesc);
            writer.WriteString(nameof(YearhalfDesc), YearhalfDesc);
            writer.WriteString(nameof(YearqtrDesc), YearqtrDesc);
            writer.WriteLong(nameof(Yearmonth), Yearmonth);
            writer.WriteString(nameof(YearmonthDesc), YearmonthDesc);
            writer.WriteString(nameof(YearweekDesc), YearweekDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppmonth = reader.ReadLong(nameof(Ppmonth));
            Ppweek = reader.ReadLong(nameof(Ppweek));
            Year = reader.ReadLong(nameof(Year));
            Yearhalf = reader.ReadLong(nameof(Yearhalf));
            Yearqtr = reader.ReadLong(nameof(Yearqtr));
            YearDesc = reader.ReadString(nameof(YearDesc));
            YearhalfDesc = reader.ReadString(nameof(YearhalfDesc));
            YearqtrDesc = reader.ReadString(nameof(YearqtrDesc));
            Yearmonth = reader.ReadLong(nameof(Yearmonth));
            YearmonthDesc = reader.ReadString(nameof(YearmonthDesc));
            YearweekDesc = reader.ReadString(nameof(YearweekDesc));
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
