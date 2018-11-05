// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ReclassDmaLookup : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "codeset")] public string Codeset { get; set; }
        [QuerySqlField(Name = "codeset_name")] public string CodesetName { get; set; }
        [QuerySqlField(Name = "code")] public long Code { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "sbname")] public string Sbname { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString("codeset", Codeset);
            writer.WriteString("codeset_name", CodesetName);
            writer.WriteLong("code", Code);
            writer.WriteString("shortname", Shortname);
            writer.WriteString("name", Name);
            writer.WriteString("description", Description);
            writer.WriteLong("displayorder", Displayorder);
            writer.WriteString("sbname", Sbname);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Codeset = reader.ReadString("codeset");
            CodesetName = reader.ReadString("codeset_name");
            Code = reader.ReadLong("code");
            Shortname = reader.ReadString("shortname");
            Name = reader.ReadString("name");
            Description = reader.ReadString("description");
            Displayorder = reader.ReadLong("displayorder");
            Sbname = reader.ReadString("sbname");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Codeset = Encoding.ASCII.GetString(buffer, 0, 30).TrimEnd();
                CodesetName = Encoding.ASCII.GetString(buffer, 30, 128).TrimEnd();
                Code = *(long*) (p + 158);
                Shortname = Encoding.ASCII.GetString(buffer, 166, 128).TrimEnd();
                Name = Encoding.ASCII.GetString(buffer, 294, 128).TrimEnd();
                Description = Encoding.ASCII.GetString(buffer, 422, 256).TrimEnd();
                Displayorder = *(long*) (p + 678);
                Sbname = Encoding.ASCII.GetString(buffer, 686, 30).TrimEnd();
            }
        }
    }
}
