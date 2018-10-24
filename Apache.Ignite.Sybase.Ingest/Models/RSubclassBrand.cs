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
            writer.WriteLong(nameof(Categorytype), Categorytype);
            writer.WriteLong(nameof(Class), Class);
            writer.WriteLong(nameof(Classification), Classification);
            writer.WriteLong(nameof(Company), Company);
            writer.WriteLong(nameof(Subclass), Subclass);
            writer.WriteLong(nameof(Supercategory), Supercategory);
            writer.WriteLong(nameof(Brand), Brand);
            writer.WriteLong(nameof(Brandfamily), Brandfamily);
            writer.WriteLong(nameof(Brandtype), Brandtype);
            writer.WriteLong(nameof(Category), Category);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Categorytype = reader.ReadLong(nameof(Categorytype));
            Class = reader.ReadLong(nameof(Class));
            Classification = reader.ReadLong(nameof(Classification));
            Company = reader.ReadLong(nameof(Company));
            Subclass = reader.ReadLong(nameof(Subclass));
            Supercategory = reader.ReadLong(nameof(Supercategory));
            Brand = reader.ReadLong(nameof(Brand));
            Brandfamily = reader.ReadLong(nameof(Brandfamily));
            Brandtype = reader.ReadLong(nameof(Brandtype));
            Category = reader.ReadLong(nameof(Category));
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
