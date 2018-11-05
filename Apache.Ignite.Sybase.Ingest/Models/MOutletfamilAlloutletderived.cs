// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MOutletfamilAlloutletderived : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "alloutletderived")] public long Alloutletderived { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }
        [QuerySqlField(Name = "alloutlet")] public long Alloutlet { get; set; }
        [QuerySqlField(Name = "alloutletfamily")] public long Alloutletfamily { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("alloutletderived", Alloutletderived);
            writer.WriteString("description", Description);
            writer.WriteLong("displayorder", Displayorder);
            writer.WriteString("name", Name);
            writer.WriteString("shortname", Shortname);
            writer.WriteDouble("startrange", Startrange);
            writer.WriteDouble("endrange", Endrange);
            writer.WriteLong("alloutlet", Alloutlet);
            writer.WriteLong("alloutletfamily", Alloutletfamily);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Alloutletderived = reader.ReadLong("alloutletderived");
            Description = reader.ReadString("description");
            Displayorder = reader.ReadLong("displayorder");
            Name = reader.ReadString("name");
            Shortname = reader.ReadString("shortname");
            Startrange = reader.ReadDouble("startrange");
            Endrange = reader.ReadDouble("endrange");
            Alloutlet = reader.ReadLong("alloutlet");
            Alloutletfamily = reader.ReadLong("alloutletfamily");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Alloutletderived = *(long*) (p + 0);
                Description = Encoding.ASCII.GetString(buffer, 8, 256).TrimEnd();
                Displayorder = *(long*) (p + 264);
                Name = Encoding.ASCII.GetString(buffer, 272, 128).TrimEnd();
                Shortname = Encoding.ASCII.GetString(buffer, 400, 128).TrimEnd();
                Startrange = *(double*) (p + 528);
                Endrange = *(double*) (p + 536);
                Alloutlet = *(long*) (p + 544);
                Alloutletfamily = *(long*) (p + 552);
            }
        }
    }
}
