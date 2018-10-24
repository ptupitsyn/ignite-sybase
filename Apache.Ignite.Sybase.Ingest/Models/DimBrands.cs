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
            writer.WriteLong(nameof(Brand), Brand);
            writer.WriteString(nameof(BrandDesc), BrandDesc);
            writer.WriteLong(nameof(Brandfamily), Brandfamily);
            writer.WriteString(nameof(BrandfamilyDesc), BrandfamilyDesc);
            writer.WriteLong(nameof(Brandtype), Brandtype);
            writer.WriteString(nameof(BrandtypeDesc), BrandtypeDesc);
            writer.WriteLong(nameof(Itemnumber), Itemnumber);
            writer.WriteString(nameof(ItemnumberDesc), ItemnumberDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Brand = reader.ReadLong(nameof(Brand));
            BrandDesc = reader.ReadString(nameof(BrandDesc));
            Brandfamily = reader.ReadLong(nameof(Brandfamily));
            BrandfamilyDesc = reader.ReadString(nameof(BrandfamilyDesc));
            Brandtype = reader.ReadLong(nameof(Brandtype));
            BrandtypeDesc = reader.ReadString(nameof(BrandtypeDesc));
            Itemnumber = reader.ReadLong(nameof(Itemnumber));
            ItemnumberDesc = reader.ReadString(nameof(ItemnumberDesc));
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
