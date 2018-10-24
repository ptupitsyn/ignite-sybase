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
            writer.WriteString(nameof(Postalcode), Postalcode);
            writer.WriteLong(nameof(Country), Country);
            writer.WriteLong(nameof(Customgeopopulation), Customgeopopulation);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Postalcode = reader.ReadString(nameof(Postalcode));
            Country = reader.ReadLong(nameof(Country));
            Customgeopopulation = reader.ReadLong(nameof(Customgeopopulation));
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
