// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimXindbrandcompanies : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "allbrandcompany")] public long Allbrandcompany { get; set; }
        [QuerySqlField(Name = "allbrandcompany_desc")] public string AllbrandcompanyDesc { get; set; }
        [QuerySqlField(Name = "allbrandderived")] public long Allbrandderived { get; set; }
        [QuerySqlField(Name = "allbrandderived_desc")] public string AllbrandderivedDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Allbrandcompany), Allbrandcompany);
            writer.WriteString(nameof(AllbrandcompanyDesc), AllbrandcompanyDesc);
            writer.WriteLong(nameof(Allbrandderived), Allbrandderived);
            writer.WriteString(nameof(AllbrandderivedDesc), AllbrandderivedDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Allbrandcompany = reader.ReadLong(nameof(Allbrandcompany));
            AllbrandcompanyDesc = reader.ReadString(nameof(AllbrandcompanyDesc));
            Allbrandderived = reader.ReadLong(nameof(Allbrandderived));
            AllbrandderivedDesc = reader.ReadString(nameof(AllbrandderivedDesc));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Allbrandcompany = *(long*) (p + 0);
                AllbrandcompanyDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Allbrandderived = *(long*) (p + 136);
                AllbrandderivedDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
            }
        }
    }
}
