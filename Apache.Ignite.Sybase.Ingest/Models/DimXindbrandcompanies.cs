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
            writer.WriteLong("allbrandcompany", Allbrandcompany);
            writer.WriteString("allbrandcompany_desc", AllbrandcompanyDesc);
            writer.WriteLong("allbrandderived", Allbrandderived);
            writer.WriteString("allbrandderived_desc", AllbrandderivedDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Allbrandcompany = reader.ReadLong("allbrandcompany");
            AllbrandcompanyDesc = reader.ReadString("allbrandcompany_desc");
            Allbrandderived = reader.ReadLong("allbrandderived");
            AllbrandderivedDesc = reader.ReadString("allbrandderived_desc");
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
