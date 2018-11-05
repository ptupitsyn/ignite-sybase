// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class RSubclassBrand : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "categorytype")] public long Categorytype { get; set; }
        [QuerySqlField(Name = "class")] public long Class { get; set; }
        [QuerySqlField(Name = "classification")] public long Classification { get; set; }
        [QuerySqlField(Name = "company")] public long Company { get; set; }
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "supercategory")] public long Supercategory { get; set; }
        [QuerySqlField(Name = "brand")] public long Brand { get; set; }
        [QuerySqlField(Name = "brandfamily")] public long Brandfamily { get; set; }
        [QuerySqlField(Name = "brandtype")] public long Brandtype { get; set; }
        [QuerySqlField(Name = "category")] public long Category { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("categorytype", Categorytype);
            writer.WriteLong("class", Class);
            writer.WriteLong("classification", Classification);
            writer.WriteLong("company", Company);
            writer.WriteLong("subclass", Subclass);
            writer.WriteLong("supercategory", Supercategory);
            writer.WriteLong("brand", Brand);
            writer.WriteLong("brandfamily", Brandfamily);
            writer.WriteLong("brandtype", Brandtype);
            writer.WriteLong("category", Category);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Categorytype = reader.ReadLong("categorytype");
            Class = reader.ReadLong("class");
            Classification = reader.ReadLong("classification");
            Company = reader.ReadLong("company");
            Subclass = reader.ReadLong("subclass");
            Supercategory = reader.ReadLong("supercategory");
            Brand = reader.ReadLong("brand");
            Brandfamily = reader.ReadLong("brandfamily");
            Brandtype = reader.ReadLong("brandtype");
            Category = reader.ReadLong("category");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Categorytype = *(long*) (p + 0);
                Class = *(long*) (p + 8);
                Classification = *(long*) (p + 16);
                Company = *(long*) (p + 24);
                Subclass = *(long*) (p + 32);
                Supercategory = *(long*) (p + 40);
                Brand = *(long*) (p + 48);
                Brandfamily = *(long*) (p + 56);
                Brandtype = *(long*) (p + 64);
                Category = *(long*) (p + 72);
            }
        }
    }
}
