// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class ReclassDmaValues : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "codeset")] public string Codeset { get; set; }
        [QuerySqlField(Name = "codeset_name")] public string CodesetName { get; set; }
        [QuerySqlField(Name = "code")] public long Code { get; set; }
        [QuerySqlField(Name = "code_name")] public string CodeName { get; set; }
        [QuerySqlField(Name = "dma")] public long Dma { get; set; }
        [QuerySqlField(Name = "sbname")] public string Sbname { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString("codeset", Codeset);
            writer.WriteString("codeset_name", CodesetName);
            writer.WriteLong("code", Code);
            writer.WriteString("code_name", CodeName);
            writer.WriteLong("dma", Dma);
            writer.WriteString("sbname", Sbname);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Codeset = reader.ReadString("codeset");
            CodesetName = reader.ReadString("codeset_name");
            Code = reader.ReadLong("code");
            CodeName = reader.ReadString("code_name");
            Dma = reader.ReadLong("dma");
            Sbname = reader.ReadString("sbname");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Codeset = Encoding.ASCII.GetString(buffer, 0, 30).TrimEnd();
                CodesetName = Encoding.ASCII.GetString(buffer, 30, 128).TrimEnd();
                Code = *(long*) (p + 158);
                CodeName = Encoding.ASCII.GetString(buffer, 166, 128).TrimEnd();
                Dma = *(long*) (p + 294);
                Sbname = Encoding.ASCII.GetString(buffer, 302, 30).TrimEnd();
            }
        }
    }
}
