// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class DimChannels : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "channel")] public long Channel { get; set; }
        [QuerySqlField(Name = "channel_desc")] public string ChannelDesc { get; set; }
        [QuerySqlField(Name = "outlet")] public long Outlet { get; set; }
        [QuerySqlField(Name = "outlet_desc")] public string OutletDesc { get; set; }
        [QuerySqlField(Name = "subchannel")] public long Subchannel { get; set; }
        [QuerySqlField(Name = "subchannel_desc")] public string SubchannelDesc { get; set; }
        [QuerySqlField(Name = "superchannel")] public long Superchannel { get; set; }
        [QuerySqlField(Name = "superchannel_desc")] public string SuperchannelDesc { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Channel), Channel);
            writer.WriteString(nameof(ChannelDesc), ChannelDesc);
            writer.WriteLong(nameof(Outlet), Outlet);
            writer.WriteString(nameof(OutletDesc), OutletDesc);
            writer.WriteLong(nameof(Subchannel), Subchannel);
            writer.WriteString(nameof(SubchannelDesc), SubchannelDesc);
            writer.WriteLong(nameof(Superchannel), Superchannel);
            writer.WriteString(nameof(SuperchannelDesc), SuperchannelDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Channel = reader.ReadLong(nameof(Channel));
            ChannelDesc = reader.ReadString(nameof(ChannelDesc));
            Outlet = reader.ReadLong(nameof(Outlet));
            OutletDesc = reader.ReadString(nameof(OutletDesc));
            Subchannel = reader.ReadLong(nameof(Subchannel));
            SubchannelDesc = reader.ReadString(nameof(SubchannelDesc));
            Superchannel = reader.ReadLong(nameof(Superchannel));
            SuperchannelDesc = reader.ReadString(nameof(SuperchannelDesc));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Channel = *(long*) (p + 0);
                ChannelDesc = Encoding.ASCII.GetString(buffer, 8, 128).TrimEnd();
                Outlet = *(long*) (p + 136);
                OutletDesc = Encoding.ASCII.GetString(buffer, 144, 128).TrimEnd();
                Subchannel = *(long*) (p + 272);
                SubchannelDesc = Encoding.ASCII.GetString(buffer, 280, 128).TrimEnd();
                Superchannel = *(long*) (p + 408);
                SuperchannelDesc = Encoding.ASCII.GetString(buffer, 416, 128).TrimEnd();
            }
        }
    }
}
