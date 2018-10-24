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
            writer.WriteString(nameof(Codeset), Codeset);
            writer.WriteString(nameof(CodesetName), CodesetName);
            writer.WriteLong(nameof(Code), Code);
            writer.WriteString(nameof(CodeName), CodeName);
            writer.WriteLong(nameof(Dma), Dma);
            writer.WriteString(nameof(Sbname), Sbname);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Codeset = reader.ReadString(nameof(Codeset));
            CodesetName = reader.ReadString(nameof(CodesetName));
            Code = reader.ReadLong(nameof(Code));
            CodeName = reader.ReadString(nameof(CodeName));
            Dma = reader.ReadLong(nameof(Dma));
            Sbname = reader.ReadString(nameof(Sbname));
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
