// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimWearergenders : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "wearergender")] public long Wearergender { get; set; }
        [QuerySqlField(Name = "wearergender_desc")] public string WearergenderDesc { get; set; }
        [QuerySqlField(Name = "wearersize")] public long Wearersize { get; set; }
        [QuerySqlField(Name = "wearersize_desc")] public string WearersizeDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Wearergender), Wearergender);
            writer.WriteString(nameof(WearergenderDesc), WearergenderDesc);
            writer.WriteLong(nameof(Wearersize), Wearersize);
            writer.WriteString(nameof(WearersizeDesc), WearersizeDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Wearergender = reader.ReadLong(nameof(Wearergender));
            WearergenderDesc = reader.ReadString(nameof(WearergenderDesc));
            Wearersize = reader.ReadLong(nameof(Wearersize));
            WearersizeDesc = reader.ReadString(nameof(WearersizeDesc));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Wearergender = *(long*) (p + 0);
                WearergenderDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Wearersize = *(long*) (p + 136);
                WearersizeDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
            }
        }
    }
}
