// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MAtproll3 : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "atproll3")] public long Atproll3 { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("atproll3", Atproll3);
            writer.WriteString("description", Description);
            writer.WriteString("shortname", Shortname);
            writer.WriteString("name", Name);
            writer.WriteLong("displayorder", Displayorder);
            writer.WriteDouble("startrange", Startrange);
            writer.WriteDouble("endrange", Endrange);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Atproll3 = reader.ReadLong("atproll3");
            Description = reader.ReadString("description");
            Shortname = reader.ReadString("shortname");
            Name = reader.ReadString("name");
            Displayorder = reader.ReadLong("displayorder");
            Startrange = reader.ReadDouble("startrange");
            Endrange = reader.ReadDouble("endrange");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Atproll3 = *(long*) (p + 0);
                Description = Encoding.ASCII.GetString(buffer, 8, 256).TrimEnd();
                Shortname = Encoding.ASCII.GetString(buffer, 264, 128).TrimEnd();
                Name = Encoding.ASCII.GetString(buffer, 392, 128).TrimEnd();
                Displayorder = *(long*) (p + 520);
                Startrange = *(double*) (p + 528);
                Endrange = *(double*) (p + 536);
            }
        }
    }
}
