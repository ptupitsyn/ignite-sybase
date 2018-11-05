// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class OdsCodesets : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "codeset")] public string Codeset { get; set; }
        [QuerySqlField(Name = "business_id")] public long BusinessId { get; set; }
        [QuerySqlField(Name = "sort_order")] public long SortOrder { get; set; }
        [QuerySqlField(Name = "abbreviation")] public string Abbreviation { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "pv_name")] public string PvName { get; set; }
        [QuerySqlField(Name = "derived_codeset")] public long DerivedCodeset { get; set; }
        [QuerySqlField(Name = "derived_codeviews_update")] public long DerivedCodeviewsUpdate { get; set; }
        [QuerySqlField(Name = "derived_mapcodes_update")] public long DerivedMapcodesUpdate { get; set; }
        [QuerySqlField(Name = "internal_codeset")] public long InternalCodeset { get; set; }
        [QuerySqlField(Name = "codeset_type")] public string CodesetType { get; set; }
        [QuerySqlField(Name = "fld_type")] public string FldType { get; set; }
        [QuerySqlField(Name = "fld_number")] public long FldNumber { get; set; }
        [QuerySqlField(Name = "multichoice_width")] public long MultichoiceWidth { get; set; }
        [QuerySqlField(Name = "collapse_code_used")] public long CollapseCodeUsed { get; set; }
        [QuerySqlField(Name = "user_defined")] public long UserDefined { get; set; }
        [QuerySqlField(Name = "extended_codeset")] public long ExtendedCodeset { get; set; }
        [QuerySqlField(Name = "equivalency_codeset")] public long EquivalencyCodeset { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString("codeset", Codeset);
            writer.WriteLong("business_id", BusinessId);
            writer.WriteLong("sort_order", SortOrder);
            writer.WriteString("abbreviation", Abbreviation);
            writer.WriteString("name", Name);
            writer.WriteString("description", Description);
            writer.WriteString("pv_name", PvName);
            writer.WriteLong("derived_codeset", DerivedCodeset);
            writer.WriteLong("derived_codeviews_update", DerivedCodeviewsUpdate);
            writer.WriteLong("derived_mapcodes_update", DerivedMapcodesUpdate);
            writer.WriteLong("internal_codeset", InternalCodeset);
            writer.WriteString("codeset_type", CodesetType);
            writer.WriteString("fld_type", FldType);
            writer.WriteLong("fld_number", FldNumber);
            writer.WriteLong("multichoice_width", MultichoiceWidth);
            writer.WriteLong("collapse_code_used", CollapseCodeUsed);
            writer.WriteLong("user_defined", UserDefined);
            writer.WriteLong("extended_codeset", ExtendedCodeset);
            writer.WriteLong("equivalency_codeset", EquivalencyCodeset);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Codeset = reader.ReadString("codeset");
            BusinessId = reader.ReadLong("business_id");
            SortOrder = reader.ReadLong("sort_order");
            Abbreviation = reader.ReadString("abbreviation");
            Name = reader.ReadString("name");
            Description = reader.ReadString("description");
            PvName = reader.ReadString("pv_name");
            DerivedCodeset = reader.ReadLong("derived_codeset");
            DerivedCodeviewsUpdate = reader.ReadLong("derived_codeviews_update");
            DerivedMapcodesUpdate = reader.ReadLong("derived_mapcodes_update");
            InternalCodeset = reader.ReadLong("internal_codeset");
            CodesetType = reader.ReadString("codeset_type");
            FldType = reader.ReadString("fld_type");
            FldNumber = reader.ReadLong("fld_number");
            MultichoiceWidth = reader.ReadLong("multichoice_width");
            CollapseCodeUsed = reader.ReadLong("collapse_code_used");
            UserDefined = reader.ReadLong("user_defined");
            ExtendedCodeset = reader.ReadLong("extended_codeset");
            EquivalencyCodeset = reader.ReadLong("equivalency_codeset");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Codeset = Encoding.ASCII.GetString(buffer, 0, 30).TrimEnd();
                BusinessId = *(long*) (p + 30);
                SortOrder = *(long*) (p + 38);
                Abbreviation = Encoding.ASCII.GetString(buffer, 46, 8).TrimEnd();
                Name = Encoding.ASCII.GetString(buffer, 54, 128).TrimEnd();
                Description = Encoding.ASCII.GetString(buffer, 182, 256).TrimEnd();
                PvName = Encoding.ASCII.GetString(buffer, 438, 8).TrimEnd();
                DerivedCodeset = *(long*) (p + 446);
                DerivedCodeviewsUpdate = *(long*) (p + 454);
                DerivedMapcodesUpdate = *(long*) (p + 462);
                InternalCodeset = *(long*) (p + 470);
                CodesetType = Encoding.ASCII.GetString(buffer, 478, 16).TrimEnd();
                FldType = Encoding.ASCII.GetString(buffer, 494, 18).TrimEnd();
                FldNumber = *(long*) (p + 512);
                MultichoiceWidth = *(long*) (p + 520);
                CollapseCodeUsed = *(long*) (p + 528);
                UserDefined = *(long*) (p + 536);
                ExtendedCodeset = *(long*) (p + 544);
                EquivalencyCodeset = *(long*) (p + 552);
            }
        }
    }
}
