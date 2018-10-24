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
            writer.WriteString(nameof(Codeset), Codeset);
            writer.WriteString(nameof(CodesetName), CodesetName);
            writer.WriteString(nameof(Sbname), Sbname);
            writer.WriteLong(nameof(Code), Code);
            writer.WriteString(nameof(Shortname), Shortname);
            writer.WriteString(nameof(Name), Name);
            writer.WriteString(nameof(Description), Description);
            writer.WriteLong(nameof(Displayorder), Displayorder);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Codeset = reader.ReadString(nameof(Codeset));
            CodesetName = reader.ReadString(nameof(CodesetName));
            Sbname = reader.ReadString(nameof(Sbname));
            Code = reader.ReadLong(nameof(Code));
            Shortname = reader.ReadString(nameof(Shortname));
            Name = reader.ReadString(nameof(Name));
            Description = reader.ReadString(nameof(Description));
            Displayorder = reader.ReadLong(nameof(Displayorder));
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
