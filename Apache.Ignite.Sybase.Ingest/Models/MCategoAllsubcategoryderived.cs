// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MCategoAllsubcategoryderived : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "allsubcategoryderived")] public long Allsubcategoryderived { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }
        [QuerySqlField(Name = "allcategoryderived")] public long Allcategoryderived { get; set; }
        [QuerySqlField(Name = "allsector")] public long Allsector { get; set; }
        [QuerySqlField(Name = "allindustry")] public long Allindustry { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Allsubcategoryderived), Allsubcategoryderived);
            writer.WriteString(nameof(Description), Description);
            writer.WriteLong(nameof(Displayorder), Displayorder);
            writer.WriteString(nameof(Name), Name);
            writer.WriteString(nameof(Shortname), Shortname);
            writer.WriteDouble(nameof(Startrange), Startrange);
            writer.WriteDouble(nameof(Endrange), Endrange);
            writer.WriteLong(nameof(Allcategoryderived), Allcategoryderived);
            writer.WriteLong(nameof(Allsector), Allsector);
            writer.WriteLong(nameof(Allindustry), Allindustry);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Allsubcategoryderived = reader.ReadLong(nameof(Allsubcategoryderived));
            Description = reader.ReadString(nameof(Description));
            Displayorder = reader.ReadLong(nameof(Displayorder));
            Name = reader.ReadString(nameof(Name));
            Shortname = reader.ReadString(nameof(Shortname));
            Startrange = reader.ReadDouble(nameof(Startrange));
            Endrange = reader.ReadDouble(nameof(Endrange));
            Allcategoryderived = reader.ReadLong(nameof(Allcategoryderived));
            Allsector = reader.ReadLong(nameof(Allsector));
            Allindustry = reader.ReadLong(nameof(Allindustry));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Allsubcategoryderived = *(long*) (p + 0);
                Description = Encoding.ASCII.GetString(buffer, 8, 256).TrimEnd();
                Displayorder = *(long*) (p + 264);
                Name = Encoding.ASCII.GetString(buffer, 272, 128).TrimEnd();
                Shortname = Encoding.ASCII.GetString(buffer, 400, 128).TrimEnd();
                Startrange = *(double*) (p + 528);
                Endrange = *(double*) (p + 536);
                Allcategoryderived = *(long*) (p + 544);
                Allsector = *(long*) (p + 552);
                Allindustry = *(long*) (p + 560);
            }
        }
    }
}
