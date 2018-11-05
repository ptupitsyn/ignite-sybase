// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class CustomgeographicsLookup : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "codeset")] public string Codeset { get; set; }
        [QuerySqlField(Name = "codeset_name")] public string CodesetName { get; set; }
        [QuerySqlField(Name = "sbname")] public string Sbname { get; set; }
        [QuerySqlField(Name = "code")] public long Code { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString("codeset", Codeset);
            writer.WriteString("codeset_name", CodesetName);
            writer.WriteString("sbname", Sbname);
            writer.WriteLong("code", Code);
            writer.WriteString("shortname", Shortname);
            writer.WriteString("name", Name);
            writer.WriteString("description", Description);
            writer.WriteLong("displayorder", Displayorder);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Codeset = reader.ReadString("codeset");
            CodesetName = reader.ReadString("codeset_name");
            Sbname = reader.ReadString("sbname");
            Code = reader.ReadLong("code");
            Shortname = reader.ReadString("shortname");
            Name = reader.ReadString("name");
            Description = reader.ReadString("description");
            Displayorder = reader.ReadLong("displayorder");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Codeset = Encoding.ASCII.GetString(buffer, 0, 30).TrimEnd();
                CodesetName = Encoding.ASCII.GetString(buffer, 30, 128).TrimEnd();
                Sbname = Encoding.ASCII.GetString(buffer, 158, 30).TrimEnd();
                Code = *(long*) (p + 188);
                Shortname = Encoding.ASCII.GetString(buffer, 196, 128).TrimEnd();
                Name = Encoding.ASCII.GetString(buffer, 324, 128).TrimEnd();
                Description = Encoding.ASCII.GetString(buffer, 452, 256).TrimEnd();
                Displayorder = *(long*) (p + 708);
            }
        }
    }
}
