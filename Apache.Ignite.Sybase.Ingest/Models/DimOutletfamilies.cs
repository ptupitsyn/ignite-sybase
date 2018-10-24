// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimOutletfamilies : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "outlet")] public long Outlet { get; set; }
        [QuerySqlField(Name = "outlet_desc")] public string OutletDesc { get; set; }
        [QuerySqlField(Name = "outletfamily")] public long Outletfamily { get; set; }
        [QuerySqlField(Name = "outletfamily_desc")] public string OutletfamilyDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Outlet), Outlet);
            writer.WriteString(nameof(OutletDesc), OutletDesc);
            writer.WriteLong(nameof(Outletfamily), Outletfamily);
            writer.WriteString(nameof(OutletfamilyDesc), OutletfamilyDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Outlet = reader.ReadLong(nameof(Outlet));
            OutletDesc = reader.ReadString(nameof(OutletDesc));
            Outletfamily = reader.ReadLong(nameof(Outletfamily));
            OutletfamilyDesc = reader.ReadString(nameof(OutletfamilyDesc));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Outlet = *(long*) (p + 0);
                OutletDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Outletfamily = *(long*) (p + 136);
                OutletfamilyDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
            }
        }
    }
}
