// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MWearersWearersize : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "wearersize")] public long Wearersize { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }
        [QuerySqlField(Name = "wearersegment")] public long Wearersegment { get; set; }
        [QuerySqlField(Name = "wearersubtype")] public long Wearersubtype { get; set; }
        [QuerySqlField(Name = "wearertype")] public long Wearertype { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Wearersize), Wearersize);
            writer.WriteString(nameof(Description), Description);
            writer.WriteLong(nameof(Displayorder), Displayorder);
            writer.WriteString(nameof(Name), Name);
            writer.WriteString(nameof(Shortname), Shortname);
            writer.WriteDouble(nameof(Startrange), Startrange);
            writer.WriteDouble(nameof(Endrange), Endrange);
            writer.WriteLong(nameof(Wearersegment), Wearersegment);
            writer.WriteLong(nameof(Wearersubtype), Wearersubtype);
            writer.WriteLong(nameof(Wearertype), Wearertype);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Wearersize = reader.ReadLong(nameof(Wearersize));
            Description = reader.ReadString(nameof(Description));
            Displayorder = reader.ReadLong(nameof(Displayorder));
            Name = reader.ReadString(nameof(Name));
            Shortname = reader.ReadString(nameof(Shortname));
            Startrange = reader.ReadDouble(nameof(Startrange));
            Endrange = reader.ReadDouble(nameof(Endrange));
            Wearersegment = reader.ReadLong(nameof(Wearersegment));
            Wearersubtype = reader.ReadLong(nameof(Wearersubtype));
            Wearertype = reader.ReadLong(nameof(Wearertype));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Wearersize = *(long*) (p + 0);
                Description = Encoding.ASCII.GetString(buffer, 8, 256).TrimEnd();
                Displayorder = *(long*) (p + 264);
                Name = Encoding.ASCII.GetString(buffer, 272, 128).TrimEnd();
                Shortname = Encoding.ASCII.GetString(buffer, 400, 128).TrimEnd();
                Startrange = *(double*) (p + 528);
                Endrange = *(double*) (p + 536);
                Wearersegment = *(long*) (p + 544);
                Wearersubtype = *(long*) (p + 552);
                Wearertype = *(long*) (p + 560);
            }
        }
    }
}
