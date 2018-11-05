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
            writer.WriteLong("brand", Brand);
            writer.WriteString("brand_desc", BrandDesc);
            writer.WriteLong("classification", Classification);
            writer.WriteString("classification_desc", ClassificationDesc);
            writer.WriteLong("itemnumber", Itemnumber);
            writer.WriteString("itemnumber_desc", ItemnumberDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Brand = reader.ReadLong("brand");
            BrandDesc = reader.ReadString("brand_desc");
            Classification = reader.ReadLong("classification");
            ClassificationDesc = reader.ReadString("classification_desc");
            Itemnumber = reader.ReadLong("itemnumber");
            ItemnumberDesc = reader.ReadString("itemnumber_desc");
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
