// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class CustomgeographicsValues : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "codeset")] public string Codeset { get; set; }
        [QuerySqlField(Name = "codeset_name")] public string CodesetName { get; set; }
        [QuerySqlField(Name = "sbname")] public string Sbname { get; set; }
        [QuerySqlField(Name = "code")] public long Code { get; set; }
        [QuerySqlField(Name = "code_name")] public string CodeName { get; set; }
        [QuerySqlField(Name = "postalcode")] public string Postalcode { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString(nameof(Codeset), Codeset);
            writer.WriteString(nameof(CodesetName), CodesetName);
            writer.WriteString(nameof(Sbname), Sbname);
            writer.WriteLong(nameof(Code), Code);
            writer.WriteString(nameof(CodeName), CodeName);
            writer.WriteString(nameof(Postalcode), Postalcode);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Codeset = reader.ReadString(nameof(Codeset));
            CodesetName = reader.ReadString(nameof(CodesetName));
            Sbname = reader.ReadString(nameof(Sbname));
            Code = reader.ReadLong(nameof(Code));
            CodeName = reader.ReadString(nameof(CodeName));
            Postalcode = reader.ReadString(nameof(Postalcode));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Codeset = Encoding.ASCII.GetString(buffer, 0, 30).TrimEnd();
                CodesetName = Encoding.ASCII.GetString(buffer, 30, 128).TrimEnd();
                Sbname = Encoding.ASCII.GetString(buffer, 158, 30).TrimEnd();
                Code = *(long*) (p + 188);
                CodeName = Encoding.ASCII.GetString(buffer, 196, 128).TrimEnd();
                Postalcode = Encoding.ASCII.GetString(buffer, 324, 20).TrimEnd();
            }
        }
    }
}
