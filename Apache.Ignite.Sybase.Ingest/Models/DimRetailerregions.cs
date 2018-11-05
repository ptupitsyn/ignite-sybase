// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimRetailerregions : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "outlet")] public long Outlet { get; set; }
        [QuerySqlField(Name = "outlet_desc")] public string OutletDesc { get; set; }
        [QuerySqlField(Name = "retailerregion")] public long Retailerregion { get; set; }
        [QuerySqlField(Name = "retailerregion_desc")] public string RetailerregionDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("outlet", Outlet);
            writer.WriteString("outlet_desc", OutletDesc);
            writer.WriteLong("retailerregion", Retailerregion);
            writer.WriteString("retailerregion_desc", RetailerregionDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Outlet = reader.ReadLong("outlet");
            OutletDesc = reader.ReadString("outlet_desc");
            Retailerregion = reader.ReadLong("retailerregion");
            RetailerregionDesc = reader.ReadString("retailerregion_desc");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Outlet = *(long*) (p + 0);
                OutletDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Retailerregion = *(long*) (p + 136);
                RetailerregionDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
            }
        }
    }
}
