// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AttrPositemsValues : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "itemid")] public long Itemid { get; set; }
        [QuerySqlField(Name = "attribute_codeset")] public string AttributeCodeset { get; set; }
        [QuerySqlField(Name = "attribute_codeset_name")] public string AttributeCodesetName { get; set; }
        [QuerySqlField(Name = "attribute_code")] public long AttributeCode { get; set; }
        [QuerySqlField(Name = "attribute_code_name")] public string AttributeCodeName { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Itemid), Itemid);
            writer.WriteString(nameof(AttributeCodeset), AttributeCodeset);
            writer.WriteString(nameof(AttributeCodesetName), AttributeCodesetName);
            writer.WriteLong(nameof(AttributeCode), AttributeCode);
            writer.WriteString(nameof(AttributeCodeName), AttributeCodeName);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Itemid = reader.ReadLong(nameof(Itemid));
            AttributeCodeset = reader.ReadString(nameof(AttributeCodeset));
            AttributeCodesetName = reader.ReadString(nameof(AttributeCodesetName));
            AttributeCode = reader.ReadLong(nameof(AttributeCode));
            AttributeCodeName = reader.ReadString(nameof(AttributeCodeName));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Itemid = *(long*) (p + 0);
                AttributeCodeset = Encoding.ASCII.GetString(buffer, 8, 30).TrimEnd();
                AttributeCodesetName = Encoding.ASCII.GetString(buffer, 38, 128).TrimEnd();
                AttributeCode = *(long*) (p + 166);
                AttributeCodeName = Encoding.ASCII.GetString(buffer, 174, 128).TrimEnd();
            }
        }
    }
}
