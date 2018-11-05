// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimWearers : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "wearersegment")] public long Wearersegment { get; set; }
        [QuerySqlField(Name = "wearersegment_desc")] public string WearersegmentDesc { get; set; }
        [QuerySqlField(Name = "wearersize")] public long Wearersize { get; set; }
        [QuerySqlField(Name = "wearersize_desc")] public string WearersizeDesc { get; set; }
        [QuerySqlField(Name = "wearersubtype")] public long Wearersubtype { get; set; }
        [QuerySqlField(Name = "wearersubtype_desc")] public string WearersubtypeDesc { get; set; }
        [QuerySqlField(Name = "wearertype")] public long Wearertype { get; set; }
        [QuerySqlField(Name = "wearertype_desc")] public string WearertypeDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("wearersegment", Wearersegment);
            writer.WriteString("wearersegment_desc", WearersegmentDesc);
            writer.WriteLong("wearersize", Wearersize);
            writer.WriteString("wearersize_desc", WearersizeDesc);
            writer.WriteLong("wearersubtype", Wearersubtype);
            writer.WriteString("wearersubtype_desc", WearersubtypeDesc);
            writer.WriteLong("wearertype", Wearertype);
            writer.WriteString("wearertype_desc", WearertypeDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Wearersegment = reader.ReadLong("wearersegment");
            WearersegmentDesc = reader.ReadString("wearersegment_desc");
            Wearersize = reader.ReadLong("wearersize");
            WearersizeDesc = reader.ReadString("wearersize_desc");
            Wearersubtype = reader.ReadLong("wearersubtype");
            WearersubtypeDesc = reader.ReadString("wearersubtype_desc");
            Wearertype = reader.ReadLong("wearertype");
            WearertypeDesc = reader.ReadString("wearertype_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Wearersegment = *(long*) (p + 0);
                WearersegmentDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Wearersize = *(long*) (p + 136);
                WearersizeDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Wearersubtype = *(long*) (p + 272);
                WearersubtypeDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
                Wearertype = *(long*) (p + 408);
                WearertypeDesc = Encoding.ASCII.GetString(buffer, 416, 128).TrimEnd();
            }
        }
    }
}
