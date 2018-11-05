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
            writer.WriteLong("allcategoryderived", Allcategoryderived);
            writer.WriteString("allcategoryderived_desc", AllcategoryderivedDesc);
            writer.WriteLong("allindustry", Allindustry);
            writer.WriteString("allindustry_desc", AllindustryDesc);
            writer.WriteLong("allsector", Allsector);
            writer.WriteString("allsector_desc", AllsectorDesc);
            writer.WriteLong("allsubcategoryderived", Allsubcategoryderived);
            writer.WriteString("allsubcategoryderived_desc", AllsubcategoryderivedDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Allcategoryderived = reader.ReadLong("allcategoryderived");
            AllcategoryderivedDesc = reader.ReadString("allcategoryderived_desc");
            Allindustry = reader.ReadLong("allindustry");
            AllindustryDesc = reader.ReadString("allindustry_desc");
            Allsector = reader.ReadLong("allsector");
            AllsectorDesc = reader.ReadString("allsector_desc");
            Allsubcategoryderived = reader.ReadLong("allsubcategoryderived");
            AllsubcategoryderivedDesc = reader.ReadString("allsubcategoryderived_desc");
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
