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
            writer.WriteLong(nameof(Code), Code);
            writer.WriteString(nameof(Codeset), Codeset);
            writer.WriteLong(nameof(BusinessId), BusinessId);
            writer.WriteLong(nameof(SortOrder), SortOrder);
            writer.WriteString(nameof(Abbreviation), Abbreviation);
            writer.WriteString(nameof(Shortname), Shortname);
            writer.WriteString(nameof(Name), Name);
            writer.WriteString(nameof(Description), Description);
            writer.WriteLong(nameof(StartRange), StartRange);
            writer.WriteLong(nameof(EndRange), EndRange);
            writer.WriteLong(nameof(MultichoiceIndex), MultichoiceIndex);
            writer.WriteString(nameof(StandardCode), StandardCode);
            writer.WriteString(nameof(InternalAbbreviation), InternalAbbreviation);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Code = reader.ReadLong(nameof(Code));
            Codeset = reader.ReadString(nameof(Codeset));
            BusinessId = reader.ReadLong(nameof(BusinessId));
            SortOrder = reader.ReadLong(nameof(SortOrder));
            Abbreviation = reader.ReadString(nameof(Abbreviation));
            Shortname = reader.ReadString(nameof(Shortname));
            Name = reader.ReadString(nameof(Name));
            Description = reader.ReadString(nameof(Description));
            StartRange = reader.ReadLong(nameof(StartRange));
            EndRange = reader.ReadLong(nameof(EndRange));
            MultichoiceIndex = reader.ReadLong(nameof(MultichoiceIndex));
            StandardCode = reader.ReadString(nameof(StandardCode));
            InternalAbbreviation = reader.ReadString(nameof(InternalAbbreviation));
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
