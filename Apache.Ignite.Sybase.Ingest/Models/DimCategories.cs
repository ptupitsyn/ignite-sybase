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
            writer.WriteLong(nameof(Category), Category);
            writer.WriteString(nameof(CategoryDesc), CategoryDesc);
            writer.WriteLong(nameof(Class), Class);
            writer.WriteString(nameof(ClassDesc), ClassDesc);
            writer.WriteLong(nameof(Subclass), Subclass);
            writer.WriteString(nameof(SubclassDesc), SubclassDesc);
            writer.WriteLong(nameof(Supercategory), Supercategory);
            writer.WriteString(nameof(SupercategoryDesc), SupercategoryDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Category = reader.ReadLong(nameof(Category));
            CategoryDesc = reader.ReadString(nameof(CategoryDesc));
            Class = reader.ReadLong(nameof(Class));
            ClassDesc = reader.ReadString(nameof(ClassDesc));
            Subclass = reader.ReadLong(nameof(Subclass));
            SubclassDesc = reader.ReadString(nameof(SubclassDesc));
            Supercategory = reader.ReadLong(nameof(Supercategory));
            SupercategoryDesc = reader.ReadString(nameof(SupercategoryDesc));
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
