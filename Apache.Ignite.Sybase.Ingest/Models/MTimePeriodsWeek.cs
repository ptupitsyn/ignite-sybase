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
            writer.WriteLong(nameof(Ppweek), Ppweek);
            writer.WriteLong(nameof(Yearweek), Yearweek);
            writer.WriteLong(nameof(Yearmonth), Yearmonth);
            writer.WriteLong(nameof(Year), Year);
            writer.WriteString(nameof(Description), Description);
            writer.WriteLong(nameof(Endofmonth), Endofmonth);
            writer.WriteLong(nameof(Ppmonth), Ppmonth);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppweek = reader.ReadLong(nameof(Ppweek));
            Yearweek = reader.ReadLong(nameof(Yearweek));
            Yearmonth = reader.ReadLong(nameof(Yearmonth));
            Year = reader.ReadLong(nameof(Year));
            Description = reader.ReadString(nameof(Description));
            Endofmonth = reader.ReadLong(nameof(Endofmonth));
            Ppmonth = reader.ReadLong(nameof(Ppmonth));
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
