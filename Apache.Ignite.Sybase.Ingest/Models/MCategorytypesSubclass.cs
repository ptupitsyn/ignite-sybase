// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MCategorytypesSubclass : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }
        [QuerySqlField(Name = "categorytype")] public long Categorytype { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("subclass", Subclass);
            writer.WriteString("description", Description);
            writer.WriteLong("displayorder", Displayorder);
            writer.WriteString("name", Name);
            writer.WriteString("shortname", Shortname);
            writer.WriteDouble("startrange", Startrange);
            writer.WriteDouble("endrange", Endrange);
            writer.WriteLong("categorytype", Categorytype);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Subclass = reader.ReadLong("subclass");
            Description = reader.ReadString("description");
            Displayorder = reader.ReadLong("displayorder");
            Name = reader.ReadString("name");
            Shortname = reader.ReadString("shortname");
            Startrange = reader.ReadDouble("startrange");
            Endrange = reader.ReadDouble("endrange");
            Categorytype = reader.ReadLong("categorytype");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Subclass = *(long*) (p + 0);
                Description = Encoding.ASCII.GetString(buffer, 8, 256).TrimEnd();
                Displayorder = *(long*) (p + 264);
                Name = Encoding.ASCII.GetString(buffer, 272, 128).TrimEnd();
                Shortname = Encoding.ASCII.GetString(buffer, 400, 128).TrimEnd();
                Startrange = *(double*) (p + 528);
                Endrange = *(double*) (p + 536);
                Categorytype = *(long*) (p + 544);
            }
        }
    }
}
