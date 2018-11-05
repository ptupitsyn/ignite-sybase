// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimXindretailcategories : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "altbusiness")] public long Altbusiness { get; set; }
        [QuerySqlField(Name = "altbusiness_desc")] public string AltbusinessDesc { get; set; }
        [QuerySqlField(Name = "retcategoryderived")] public long Retcategoryderived { get; set; }
        [QuerySqlField(Name = "retcategoryderived_desc")] public string RetcategoryderivedDesc { get; set; }
        [QuerySqlField(Name = "retcategorygroupderived")] public long Retcategorygroupderived { get; set; }
        [QuerySqlField(Name = "retcategorygroupderived_desc")] public string RetcategorygroupderivedDesc { get; set; }
        [QuerySqlField(Name = "rethidsubcategoryderived")] public long Rethidsubcategoryderived { get; set; }
        [QuerySqlField(Name = "rethidsubcategoryderived_desc")] public string RethidsubcategoryderivedDesc { get; set; }
        [QuerySqlField(Name = "retsubcategoryderived")] public long Retsubcategoryderived { get; set; }
        [QuerySqlField(Name = "retsubcategoryderived_desc")] public string RetsubcategoryderivedDesc { get; set; }
        [QuerySqlField(Name = "retsupercategoryderived")] public long Retsupercategoryderived { get; set; }
        [QuerySqlField(Name = "retsupercategoryderived_desc")] public string RetsupercategoryderivedDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("altbusiness", Altbusiness);
            writer.WriteString("altbusiness_desc", AltbusinessDesc);
            writer.WriteLong("retcategoryderived", Retcategoryderived);
            writer.WriteString("retcategoryderived_desc", RetcategoryderivedDesc);
            writer.WriteLong("retcategorygroupderived", Retcategorygroupderived);
            writer.WriteString("retcategorygroupderived_desc", RetcategorygroupderivedDesc);
            writer.WriteLong("rethidsubcategoryderived", Rethidsubcategoryderived);
            writer.WriteString("rethidsubcategoryderived_desc", RethidsubcategoryderivedDesc);
            writer.WriteLong("retsubcategoryderived", Retsubcategoryderived);
            writer.WriteString("retsubcategoryderived_desc", RetsubcategoryderivedDesc);
            writer.WriteLong("retsupercategoryderived", Retsupercategoryderived);
            writer.WriteString("retsupercategoryderived_desc", RetsupercategoryderivedDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Altbusiness = reader.ReadLong("altbusiness");
            AltbusinessDesc = reader.ReadString("altbusiness_desc");
            Retcategoryderived = reader.ReadLong("retcategoryderived");
            RetcategoryderivedDesc = reader.ReadString("retcategoryderived_desc");
            Retcategorygroupderived = reader.ReadLong("retcategorygroupderived");
            RetcategorygroupderivedDesc = reader.ReadString("retcategorygroupderived_desc");
            Rethidsubcategoryderived = reader.ReadLong("rethidsubcategoryderived");
            RethidsubcategoryderivedDesc = reader.ReadString("rethidsubcategoryderived_desc");
            Retsubcategoryderived = reader.ReadLong("retsubcategoryderived");
            RetsubcategoryderivedDesc = reader.ReadString("retsubcategoryderived_desc");
            Retsupercategoryderived = reader.ReadLong("retsupercategoryderived");
            RetsupercategoryderivedDesc = reader.ReadString("retsupercategoryderived_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Altbusiness = *(long*) (p + 0);
                AltbusinessDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Retcategoryderived = *(long*) (p + 136);
                RetcategoryderivedDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Retcategorygroupderived = *(long*) (p + 272);
                RetcategorygroupderivedDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
                Rethidsubcategoryderived = *(long*) (p + 408);
                RethidsubcategoryderivedDesc = Encoding.ASCII.GetString(buffer, 416, 128).TrimEnd();
                Retsubcategoryderived = *(long*) (p + 544);
                RetsubcategoryderivedDesc = Encoding.ASCII.GetString(buffer, 552, 128).TrimEnd();
                Retsupercategoryderived = *(long*) (p + 680);
                RetsupercategoryderivedDesc = Encoding.ASCII.GetString(buffer, 688, 128).TrimEnd();
            }
        }
    }
}
