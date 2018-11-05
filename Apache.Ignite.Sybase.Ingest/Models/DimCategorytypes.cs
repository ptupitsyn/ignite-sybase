// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimCategorytypes : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "categorytype")] public long Categorytype { get; set; }
        [QuerySqlField(Name = "categorytype_desc")] public string CategorytypeDesc { get; set; }
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "subclass_desc")] public string SubclassDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("categorytype", Categorytype);
            writer.WriteString("categorytype_desc", CategorytypeDesc);
            writer.WriteLong("subclass", Subclass);
            writer.WriteString("subclass_desc", SubclassDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Categorytype = reader.ReadLong("categorytype");
            CategorytypeDesc = reader.ReadString("categorytype_desc");
            Subclass = reader.ReadLong("subclass");
            SubclassDesc = reader.ReadString("subclass_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Categorytype = *(long*) (p + 0);
                CategorytypeDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Subclass = *(long*) (p + 136);
                SubclassDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
            }
        }
    }
}
