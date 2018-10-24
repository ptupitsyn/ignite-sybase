// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MRetaRetcategorygroupderived : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "retcategorygroupderived")] public long Retcategorygroupderived { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }
        [QuerySqlField(Name = "retsupercategoryderived")] public long Retsupercategoryderived { get; set; }
        [QuerySqlField(Name = "altbusiness")] public long Altbusiness { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Retcategorygroupderived), Retcategorygroupderived);
            writer.WriteString(nameof(Description), Description);
            writer.WriteLong(nameof(Displayorder), Displayorder);
            writer.WriteString(nameof(Name), Name);
            writer.WriteString(nameof(Shortname), Shortname);
            writer.WriteDouble(nameof(Startrange), Startrange);
            writer.WriteDouble(nameof(Endrange), Endrange);
            writer.WriteLong(nameof(Retsupercategoryderived), Retsupercategoryderived);
            writer.WriteLong(nameof(Altbusiness), Altbusiness);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Retcategorygroupderived = reader.ReadLong(nameof(Retcategorygroupderived));
            Description = reader.ReadString(nameof(Description));
            Displayorder = reader.ReadLong(nameof(Displayorder));
            Name = reader.ReadString(nameof(Name));
            Shortname = reader.ReadString(nameof(Shortname));
            Startrange = reader.ReadDouble(nameof(Startrange));
            Endrange = reader.ReadDouble(nameof(Endrange));
            Retsupercategoryderived = reader.ReadLong(nameof(Retsupercategoryderived));
            Altbusiness = reader.ReadLong(nameof(Altbusiness));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Retcategorygroupderived = *(long*) (p + 0);
                Description = Encoding.ASCII.GetString(buffer, 8, 256).TrimEnd();
                Displayorder = *(long*) (p + 264);
                Name = Encoding.ASCII.GetString(buffer, 272, 128).TrimEnd();
                Shortname = Encoding.ASCII.GetString(buffer, 400, 128).TrimEnd();
                Startrange = *(double*) (p + 528);
                Endrange = *(double*) (p + 536);
                Retsupercategoryderived = *(long*) (p + 544);
                Altbusiness = *(long*) (p + 552);
            }
        }
    }
}
