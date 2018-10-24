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
            writer.WriteLong(nameof(Altbusiness), Altbusiness);
            writer.WriteString(nameof(AltbusinessDesc), AltbusinessDesc);
            writer.WriteLong(nameof(Retcategoryderived), Retcategoryderived);
            writer.WriteString(nameof(RetcategoryderivedDesc), RetcategoryderivedDesc);
            writer.WriteLong(nameof(Retcategorygroupderived), Retcategorygroupderived);
            writer.WriteString(nameof(RetcategorygroupderivedDesc), RetcategorygroupderivedDesc);
            writer.WriteLong(nameof(Rethidsubcategoryderived), Rethidsubcategoryderived);
            writer.WriteString(nameof(RethidsubcategoryderivedDesc), RethidsubcategoryderivedDesc);
            writer.WriteLong(nameof(Retsubcategoryderived), Retsubcategoryderived);
            writer.WriteString(nameof(RetsubcategoryderivedDesc), RetsubcategoryderivedDesc);
            writer.WriteLong(nameof(Retsupercategoryderived), Retsupercategoryderived);
            writer.WriteString(nameof(RetsupercategoryderivedDesc), RetsupercategoryderivedDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Altbusiness = reader.ReadLong(nameof(Altbusiness));
            AltbusinessDesc = reader.ReadString(nameof(AltbusinessDesc));
            Retcategoryderived = reader.ReadLong(nameof(Retcategoryderived));
            RetcategoryderivedDesc = reader.ReadString(nameof(RetcategoryderivedDesc));
            Retcategorygroupderived = reader.ReadLong(nameof(Retcategorygroupderived));
            RetcategorygroupderivedDesc = reader.ReadString(nameof(RetcategorygroupderivedDesc));
            Rethidsubcategoryderived = reader.ReadLong(nameof(Rethidsubcategoryderived));
            RethidsubcategoryderivedDesc = reader.ReadString(nameof(RethidsubcategoryderivedDesc));
            Retsubcategoryderived = reader.ReadLong(nameof(Retsubcategoryderived));
            RetsubcategoryderivedDesc = reader.ReadString(nameof(RetsubcategoryderivedDesc));
            Retsupercategoryderived = reader.ReadLong(nameof(Retsupercategoryderived));
            RetsupercategoryderivedDesc = reader.ReadString(nameof(RetsupercategoryderivedDesc));
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
