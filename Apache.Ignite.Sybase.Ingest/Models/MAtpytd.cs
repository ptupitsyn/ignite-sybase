// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MAtpytd : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "atpytd")] public long Atpytd { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Atpytd), Atpytd);
            writer.WriteString(nameof(Description), Description);
            writer.WriteString(nameof(Shortname), Shortname);
            writer.WriteString(nameof(Name), Name);
            writer.WriteLong(nameof(Displayorder), Displayorder);
            writer.WriteDouble(nameof(Startrange), Startrange);
            writer.WriteDouble(nameof(Endrange), Endrange);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Atpytd = reader.ReadLong(nameof(Atpytd));
            Description = reader.ReadString(nameof(Description));
            Shortname = reader.ReadString(nameof(Shortname));
            Name = reader.ReadString(nameof(Name));
            Displayorder = reader.ReadLong(nameof(Displayorder));
            Startrange = reader.ReadDouble(nameof(Startrange));
            Endrange = reader.ReadDouble(nameof(Endrange));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Atpytd = *(long*) (p + 0);
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
