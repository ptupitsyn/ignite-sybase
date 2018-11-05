// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class PostalcodeAttributes : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "postalcode")] public string Postalcode { get; set; }
        [QuerySqlField(Name = "country")] public long Country { get; set; }
        [QuerySqlField(Name = "customgeopopulation")] public long Customgeopopulation { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString("postalcode", Postalcode);
            writer.WriteLong("country", Country);
            writer.WriteLong("customgeopopulation", Customgeopopulation);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Postalcode = reader.ReadString("postalcode");
            Country = reader.ReadLong("country");
            Customgeopopulation = reader.ReadLong("customgeopopulation");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Postalcode = Encoding.ASCII.GetString(buffer, 0, 20).TrimEnd();
                Country = *(long*) (p + 20);
                Customgeopopulation = *(long*) (p + 28);
            }
        }
    }
}
