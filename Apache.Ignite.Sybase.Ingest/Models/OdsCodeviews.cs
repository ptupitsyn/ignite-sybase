// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class OdsCodeviews : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "code")] public long Code { get; set; }
        [QuerySqlField(Name = "codeset")] public string Codeset { get; set; }
        [QuerySqlField(Name = "business_id")] public long BusinessId { get; set; }
        [QuerySqlField(Name = "sort_order")] public long SortOrder { get; set; }
        [QuerySqlField(Name = "collapse_code")] public long CollapseCode { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("code", Code);
            writer.WriteString("codeset", Codeset);
            writer.WriteLong("business_id", BusinessId);
            writer.WriteLong("sort_order", SortOrder);
            writer.WriteLong("collapse_code", CollapseCode);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Code = reader.ReadLong("code");
            Codeset = reader.ReadString("codeset");
            BusinessId = reader.ReadLong("business_id");
            SortOrder = reader.ReadLong("sort_order");
            CollapseCode = reader.ReadLong("collapse_code");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Code = *(long*) (p + 0);
                Codeset = Encoding.ASCII.GetString(buffer, 8, 30).TrimEnd();
                BusinessId = *(long*) (p + 38);
                SortOrder = *(long*) (p + 46);
                CollapseCode = *(long*) (p + 54);
            }
        }
    }
}
