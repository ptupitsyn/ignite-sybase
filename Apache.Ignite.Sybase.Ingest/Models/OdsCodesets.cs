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
            writer.WriteString(nameof(Codeset), Codeset);
            writer.WriteLong(nameof(BusinessId), BusinessId);
            writer.WriteLong(nameof(SortOrder), SortOrder);
            writer.WriteString(nameof(Abbreviation), Abbreviation);
            writer.WriteString(nameof(Name), Name);
            writer.WriteString(nameof(Description), Description);
            writer.WriteString(nameof(PvName), PvName);
            writer.WriteLong(nameof(DerivedCodeset), DerivedCodeset);
            writer.WriteLong(nameof(DerivedCodeviewsUpdate), DerivedCodeviewsUpdate);
            writer.WriteLong(nameof(DerivedMapcodesUpdate), DerivedMapcodesUpdate);
            writer.WriteLong(nameof(InternalCodeset), InternalCodeset);
            writer.WriteString(nameof(CodesetType), CodesetType);
            writer.WriteString(nameof(FldType), FldType);
            writer.WriteLong(nameof(FldNumber), FldNumber);
            writer.WriteLong(nameof(MultichoiceWidth), MultichoiceWidth);
            writer.WriteLong(nameof(CollapseCodeUsed), CollapseCodeUsed);
            writer.WriteLong(nameof(UserDefined), UserDefined);
            writer.WriteLong(nameof(ExtendedCodeset), ExtendedCodeset);
            writer.WriteLong(nameof(EquivalencyCodeset), EquivalencyCodeset);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Codeset = reader.ReadString(nameof(Codeset));
            BusinessId = reader.ReadLong(nameof(BusinessId));
            SortOrder = reader.ReadLong(nameof(SortOrder));
            Abbreviation = reader.ReadString(nameof(Abbreviation));
            Name = reader.ReadString(nameof(Name));
            Description = reader.ReadString(nameof(Description));
            PvName = reader.ReadString(nameof(PvName));
            DerivedCodeset = reader.ReadLong(nameof(DerivedCodeset));
            DerivedCodeviewsUpdate = reader.ReadLong(nameof(DerivedCodeviewsUpdate));
            DerivedMapcodesUpdate = reader.ReadLong(nameof(DerivedMapcodesUpdate));
            InternalCodeset = reader.ReadLong(nameof(InternalCodeset));
            CodesetType = reader.ReadString(nameof(CodesetType));
            FldType = reader.ReadString(nameof(FldType));
            FldNumber = reader.ReadLong(nameof(FldNumber));
            MultichoiceWidth = reader.ReadLong(nameof(MultichoiceWidth));
            CollapseCodeUsed = reader.ReadLong(nameof(CollapseCodeUsed));
            UserDefined = reader.ReadLong(nameof(UserDefined));
            ExtendedCodeset = reader.ReadLong(nameof(ExtendedCodeset));
            EquivalencyCodeset = reader.ReadLong(nameof(EquivalencyCodeset));
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
