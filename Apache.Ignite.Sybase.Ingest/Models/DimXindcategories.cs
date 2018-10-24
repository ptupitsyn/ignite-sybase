// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimXindcategories : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "allcategoryderived")] public long Allcategoryderived { get; set; }
        [QuerySqlField(Name = "allcategoryderived_desc")] public string AllcategoryderivedDesc { get; set; }
        [QuerySqlField(Name = "allindustry")] public long Allindustry { get; set; }
        [QuerySqlField(Name = "allindustry_desc")] public string AllindustryDesc { get; set; }
        [QuerySqlField(Name = "allsector")] public long Allsector { get; set; }
        [QuerySqlField(Name = "allsector_desc")] public string AllsectorDesc { get; set; }
        [QuerySqlField(Name = "allsubcategoryderived")] public long Allsubcategoryderived { get; set; }
        [QuerySqlField(Name = "allsubcategoryderived_desc")] public string AllsubcategoryderivedDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Allcategoryderived), Allcategoryderived);
            writer.WriteString(nameof(AllcategoryderivedDesc), AllcategoryderivedDesc);
            writer.WriteLong(nameof(Allindustry), Allindustry);
            writer.WriteString(nameof(AllindustryDesc), AllindustryDesc);
            writer.WriteLong(nameof(Allsector), Allsector);
            writer.WriteString(nameof(AllsectorDesc), AllsectorDesc);
            writer.WriteLong(nameof(Allsubcategoryderived), Allsubcategoryderived);
            writer.WriteString(nameof(AllsubcategoryderivedDesc), AllsubcategoryderivedDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Allcategoryderived = reader.ReadLong(nameof(Allcategoryderived));
            AllcategoryderivedDesc = reader.ReadString(nameof(AllcategoryderivedDesc));
            Allindustry = reader.ReadLong(nameof(Allindustry));
            AllindustryDesc = reader.ReadString(nameof(AllindustryDesc));
            Allsector = reader.ReadLong(nameof(Allsector));
            AllsectorDesc = reader.ReadString(nameof(AllsectorDesc));
            Allsubcategoryderived = reader.ReadLong(nameof(Allsubcategoryderived));
            AllsubcategoryderivedDesc = reader.ReadString(nameof(AllsubcategoryderivedDesc));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Allcategoryderived = *(long*) (p + 0);
                AllcategoryderivedDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Allindustry = *(long*) (p + 136);
                AllindustryDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Allsector = *(long*) (p + 272);
                AllsectorDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
                Allsubcategoryderived = *(long*) (p + 408);
                AllsubcategoryderivedDesc = Encoding.ASCII.GetString(buffer, 416, 128).TrimEnd();
            }
        }
    }
}
