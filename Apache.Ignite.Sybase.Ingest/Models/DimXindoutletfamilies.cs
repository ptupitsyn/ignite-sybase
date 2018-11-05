// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimXindoutletfamilies : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "alloutlet")] public long Alloutlet { get; set; }
        [QuerySqlField(Name = "alloutlet_desc")] public string AlloutletDesc { get; set; }
        [QuerySqlField(Name = "alloutletderived")] public long Alloutletderived { get; set; }
        [QuerySqlField(Name = "alloutletderived_desc")] public string AlloutletderivedDesc { get; set; }
        [QuerySqlField(Name = "alloutletfamily")] public long Alloutletfamily { get; set; }
        [QuerySqlField(Name = "alloutletfamily_desc")] public string AlloutletfamilyDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("alloutlet", Alloutlet);
            writer.WriteString("alloutlet_desc", AlloutletDesc);
            writer.WriteLong("alloutletderived", Alloutletderived);
            writer.WriteString("alloutletderived_desc", AlloutletderivedDesc);
            writer.WriteLong("alloutletfamily", Alloutletfamily);
            writer.WriteString("alloutletfamily_desc", AlloutletfamilyDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Alloutlet = reader.ReadLong("alloutlet");
            AlloutletDesc = reader.ReadString("alloutlet_desc");
            Alloutletderived = reader.ReadLong("alloutletderived");
            AlloutletderivedDesc = reader.ReadString("alloutletderived_desc");
            Alloutletfamily = reader.ReadLong("alloutletfamily");
            AlloutletfamilyDesc = reader.ReadString("alloutletfamily_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Alloutlet = *(long*) (p + 0);
                AlloutletDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Alloutletderived = *(long*) (p + 136);
                AlloutletderivedDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Alloutletfamily = *(long*) (p + 272);
                AlloutletfamilyDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
            }
        }
    }
}
