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
            writer.WriteLong(nameof(Alloutlet), Alloutlet);
            writer.WriteString(nameof(AlloutletDesc), AlloutletDesc);
            writer.WriteLong(nameof(Alloutletderived), Alloutletderived);
            writer.WriteString(nameof(AlloutletderivedDesc), AlloutletderivedDesc);
            writer.WriteLong(nameof(Alloutletfamily), Alloutletfamily);
            writer.WriteString(nameof(AlloutletfamilyDesc), AlloutletfamilyDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Alloutlet = reader.ReadLong(nameof(Alloutlet));
            AlloutletDesc = reader.ReadString(nameof(AlloutletDesc));
            Alloutletderived = reader.ReadLong(nameof(Alloutletderived));
            AlloutletderivedDesc = reader.ReadString(nameof(AlloutletderivedDesc));
            Alloutletfamily = reader.ReadLong(nameof(Alloutletfamily));
            AlloutletfamilyDesc = reader.ReadString(nameof(AlloutletfamilyDesc));
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
