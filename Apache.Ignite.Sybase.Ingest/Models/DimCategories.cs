// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimCategories : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "category")] public long Category { get; set; }
        [QuerySqlField(Name = "category_desc")] public string CategoryDesc { get; set; }
        [QuerySqlField(Name = "class")] public long Class { get; set; }
        [QuerySqlField(Name = "class_desc")] public string ClassDesc { get; set; }
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "subclass_desc")] public string SubclassDesc { get; set; }
        [QuerySqlField(Name = "supercategory")] public long Supercategory { get; set; }
        [QuerySqlField(Name = "supercategory_desc")] public string SupercategoryDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("category", Category);
            writer.WriteString("category_desc", CategoryDesc);
            writer.WriteLong("class", Class);
            writer.WriteString("class_desc", ClassDesc);
            writer.WriteLong("subclass", Subclass);
            writer.WriteString("subclass_desc", SubclassDesc);
            writer.WriteLong("supercategory", Supercategory);
            writer.WriteString("supercategory_desc", SupercategoryDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Category = reader.ReadLong("category");
            CategoryDesc = reader.ReadString("category_desc");
            Class = reader.ReadLong("class");
            ClassDesc = reader.ReadString("class_desc");
            Subclass = reader.ReadLong("subclass");
            SubclassDesc = reader.ReadString("subclass_desc");
            Supercategory = reader.ReadLong("supercategory");
            SupercategoryDesc = reader.ReadString("supercategory_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Category = *(long*) (p + 0);
                CategoryDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Class = *(long*) (p + 136);
                ClassDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Subclass = *(long*) (p + 272);
                SubclassDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
                Supercategory = *(long*) (p + 408);
                SupercategoryDesc = Encoding.ASCII.GetString(buffer, 416, 128).TrimEnd();
            }
        }
    }
}
