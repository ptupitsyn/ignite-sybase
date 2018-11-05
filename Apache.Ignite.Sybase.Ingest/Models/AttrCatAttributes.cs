// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AttrCatAttributes : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "category")] public long Category { get; set; }
        [QuerySqlField(Name = "attribute_dependent_codeset")] public string AttributeDependentCodeset { get; set; }
        [QuerySqlField(Name = "attribute_name")] public string AttributeName { get; set; }
        [QuerySqlField(Name = "codeset_type")] public string CodesetType { get; set; }
        [QuerySqlField(Name = "dependent_codeset")] public string DependentCodeset { get; set; }
        [QuerySqlField(Name = "hidden")] public long Hidden { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("category", Category);
            writer.WriteString("attribute_dependent_codeset", AttributeDependentCodeset);
            writer.WriteString("attribute_name", AttributeName);
            writer.WriteString("codeset_type", CodesetType);
            writer.WriteString("dependent_codeset", DependentCodeset);
            writer.WriteLong("hidden", Hidden);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Category = reader.ReadLong("category");
            AttributeDependentCodeset = reader.ReadString("attribute_dependent_codeset");
            AttributeName = reader.ReadString("attribute_name");
            CodesetType = reader.ReadString("codeset_type");
            DependentCodeset = reader.ReadString("dependent_codeset");
            Hidden = reader.ReadLong("hidden");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Category = *(long*) (p + 0);
                AttributeDependentCodeset = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                AttributeName = Encoding.ASCII.GetString(buffer, 136, 128).TrimEnd();
                CodesetType = Encoding.ASCII.GetString(buffer, 264, 16).TrimEnd();
                DependentCodeset = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
                Hidden = *(long*) (p + 408);
            }
        }
    }
}
