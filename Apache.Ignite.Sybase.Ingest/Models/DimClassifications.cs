// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimClassifications : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "brand")] public long Brand { get; set; }
        [QuerySqlField(Name = "brand_desc")] public string BrandDesc { get; set; }
        [QuerySqlField(Name = "classification")] public long Classification { get; set; }
        [QuerySqlField(Name = "classification_desc")] public string ClassificationDesc { get; set; }
        [QuerySqlField(Name = "itemnumber")] public long Itemnumber { get; set; }
        [QuerySqlField(Name = "itemnumber_desc")] public string ItemnumberDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Brand), Brand);
            writer.WriteString(nameof(BrandDesc), BrandDesc);
            writer.WriteLong(nameof(Classification), Classification);
            writer.WriteString(nameof(ClassificationDesc), ClassificationDesc);
            writer.WriteLong(nameof(Itemnumber), Itemnumber);
            writer.WriteString(nameof(ItemnumberDesc), ItemnumberDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Brand = reader.ReadLong(nameof(Brand));
            BrandDesc = reader.ReadString(nameof(BrandDesc));
            Classification = reader.ReadLong(nameof(Classification));
            ClassificationDesc = reader.ReadString(nameof(ClassificationDesc));
            Itemnumber = reader.ReadLong(nameof(Itemnumber));
            ItemnumberDesc = reader.ReadString(nameof(ItemnumberDesc));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Brand = *(long*) (p + 0);
                BrandDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Classification = *(long*) (p + 136);
                ClassificationDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Itemnumber = *(long*) (p + 272);
                ItemnumberDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
            }
        }
    }
}
