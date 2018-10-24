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
            writer.WriteLong(nameof(Category), Category);
            writer.WriteString(nameof(AttributeDependentCodeset), AttributeDependentCodeset);
            writer.WriteString(nameof(AttributeName), AttributeName);
            writer.WriteString(nameof(CodesetType), CodesetType);
            writer.WriteString(nameof(DependentCodeset), DependentCodeset);
            writer.WriteLong(nameof(Hidden), Hidden);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Category = reader.ReadLong(nameof(Category));
            AttributeDependentCodeset = reader.ReadString(nameof(AttributeDependentCodeset));
            AttributeName = reader.ReadString(nameof(AttributeName));
            CodesetType = reader.ReadString(nameof(CodesetType));
            DependentCodeset = reader.ReadString(nameof(DependentCodeset));
            Hidden = reader.ReadLong(nameof(Hidden));
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
