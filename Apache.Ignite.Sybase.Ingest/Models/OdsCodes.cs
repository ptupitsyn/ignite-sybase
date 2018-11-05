// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class OdsCodes : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "code")] public long Code { get; set; }
        [QuerySqlField(Name = "codeset")] public string Codeset { get; set; }
        [QuerySqlField(Name = "business_id")] public long BusinessId { get; set; }
        [QuerySqlField(Name = "sort_order")] public long SortOrder { get; set; }
        [QuerySqlField(Name = "abbreviation")] public string Abbreviation { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "start_range")] public long StartRange { get; set; }
        [QuerySqlField(Name = "end_range")] public long EndRange { get; set; }
        [QuerySqlField(Name = "multichoice_index")] public long MultichoiceIndex { get; set; }
        [QuerySqlField(Name = "standard_code")] public string StandardCode { get; set; }
        [QuerySqlField(Name = "internal_abbreviation")] public string InternalAbbreviation { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("code", Code);
            writer.WriteString("codeset", Codeset);
            writer.WriteLong("business_id", BusinessId);
            writer.WriteLong("sort_order", SortOrder);
            writer.WriteString("abbreviation", Abbreviation);
            writer.WriteString("shortname", Shortname);
            writer.WriteString("name", Name);
            writer.WriteString("description", Description);
            writer.WriteLong("start_range", StartRange);
            writer.WriteLong("end_range", EndRange);
            writer.WriteLong("multichoice_index", MultichoiceIndex);
            writer.WriteString("standard_code", StandardCode);
            writer.WriteString("internal_abbreviation", InternalAbbreviation);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Code = reader.ReadLong("code");
            Codeset = reader.ReadString("codeset");
            BusinessId = reader.ReadLong("business_id");
            SortOrder = reader.ReadLong("sort_order");
            Abbreviation = reader.ReadString("abbreviation");
            Shortname = reader.ReadString("shortname");
            Name = reader.ReadString("name");
            Description = reader.ReadString("description");
            StartRange = reader.ReadLong("start_range");
            EndRange = reader.ReadLong("end_range");
            MultichoiceIndex = reader.ReadLong("multichoice_index");
            StandardCode = reader.ReadString("standard_code");
            InternalAbbreviation = reader.ReadString("internal_abbreviation");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Code = *(long*) (p + 0);
                Codeset = Encoding.ASCII.GetString(buffer, 8, 30).TrimEnd();
                BusinessId = *(long*) (p + 38);
                SortOrder = *(long*) (p + 46);
                Abbreviation = Encoding.ASCII.GetString(buffer, 54, 8).TrimEnd();
                Shortname = Encoding.ASCII.GetString(buffer, 62, 128).TrimEnd();
                Name = Encoding.ASCII.GetString(buffer, 190, 128).TrimEnd();
                Description = Encoding.ASCII.GetString(buffer, 318, 256).TrimEnd();
                StartRange = *(long*) (p + 574);
                EndRange = *(long*) (p + 582);
                MultichoiceIndex = *(long*) (p + 590);
                StandardCode = Encoding.ASCII.GetString(buffer, 598, 30).TrimEnd();
                InternalAbbreviation = Encoding.ASCII.GetString(buffer, 628, 80).TrimEnd();
            }
        }
    }
}
