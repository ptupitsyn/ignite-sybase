// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimXindbrands : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "allbrand")] public long Allbrand { get; set; }
        [QuerySqlField(Name = "allbrand_desc")] public string AllbrandDesc { get; set; }
        [QuerySqlField(Name = "allbrandderived")] public long Allbrandderived { get; set; }
        [QuerySqlField(Name = "allbrandderived_desc")] public string AllbrandderivedDesc { get; set; }
        [QuerySqlField(Name = "allbrandfamily")] public long Allbrandfamily { get; set; }
        [QuerySqlField(Name = "allbrandfamily_desc")] public string AllbrandfamilyDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("allbrand", Allbrand);
            writer.WriteString("allbrand_desc", AllbrandDesc);
            writer.WriteLong("allbrandderived", Allbrandderived);
            writer.WriteString("allbrandderived_desc", AllbrandderivedDesc);
            writer.WriteLong("allbrandfamily", Allbrandfamily);
            writer.WriteString("allbrandfamily_desc", AllbrandfamilyDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Allbrand = reader.ReadLong("allbrand");
            AllbrandDesc = reader.ReadString("allbrand_desc");
            Allbrandderived = reader.ReadLong("allbrandderived");
            AllbrandderivedDesc = reader.ReadString("allbrandderived_desc");
            Allbrandfamily = reader.ReadLong("allbrandfamily");
            AllbrandfamilyDesc = reader.ReadString("allbrandfamily_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Allbrand = *(long*) (p + 0);
                AllbrandDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Allbrandderived = *(long*) (p + 136);
                AllbrandderivedDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Allbrandfamily = *(long*) (p + 272);
                AllbrandfamilyDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
            }
        }
    }
}
