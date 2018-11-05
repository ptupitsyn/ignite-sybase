// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimBrands : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "brand")] public long Brand { get; set; }
        [QuerySqlField(Name = "brand_desc")] public string BrandDesc { get; set; }
        [QuerySqlField(Name = "brandfamily")] public long Brandfamily { get; set; }
        [QuerySqlField(Name = "brandfamily_desc")] public string BrandfamilyDesc { get; set; }
        [QuerySqlField(Name = "brandtype")] public long Brandtype { get; set; }
        [QuerySqlField(Name = "brandtype_desc")] public string BrandtypeDesc { get; set; }
        [QuerySqlField(Name = "itemnumber")] public long Itemnumber { get; set; }
        [QuerySqlField(Name = "itemnumber_desc")] public string ItemnumberDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("brand", Brand);
            writer.WriteString("brand_desc", BrandDesc);
            writer.WriteLong("brandfamily", Brandfamily);
            writer.WriteString("brandfamily_desc", BrandfamilyDesc);
            writer.WriteLong("brandtype", Brandtype);
            writer.WriteString("brandtype_desc", BrandtypeDesc);
            writer.WriteLong("itemnumber", Itemnumber);
            writer.WriteString("itemnumber_desc", ItemnumberDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Brand = reader.ReadLong("brand");
            BrandDesc = reader.ReadString("brand_desc");
            Brandfamily = reader.ReadLong("brandfamily");
            BrandfamilyDesc = reader.ReadString("brandfamily_desc");
            Brandtype = reader.ReadLong("brandtype");
            BrandtypeDesc = reader.ReadString("brandtype_desc");
            Itemnumber = reader.ReadLong("itemnumber");
            ItemnumberDesc = reader.ReadString("itemnumber_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Brand = *(long*) (p + 0);
                BrandDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Brandfamily = *(long*) (p + 136);
                BrandfamilyDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Brandtype = *(long*) (p + 272);
                BrandtypeDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
                Itemnumber = *(long*) (p + 408);
                ItemnumberDesc = Encoding.ASCII.GetString(buffer, 416, 128).TrimEnd();
            }
        }
    }
}
