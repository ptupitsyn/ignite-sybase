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
            writer.WriteLong("channel", Channel);
            writer.WriteString("channel_desc", ChannelDesc);
            writer.WriteLong("outlet", Outlet);
            writer.WriteString("outlet_desc", OutletDesc);
            writer.WriteLong("subchannel", Subchannel);
            writer.WriteString("subchannel_desc", SubchannelDesc);
            writer.WriteLong("superchannel", Superchannel);
            writer.WriteString("superchannel_desc", SuperchannelDesc);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Channel = reader.ReadLong("channel");
            ChannelDesc = reader.ReadString("channel_desc");
            Outlet = reader.ReadLong("outlet");
            OutletDesc = reader.ReadString("outlet_desc");
            Subchannel = reader.ReadLong("subchannel");
            SubchannelDesc = reader.ReadString("subchannel_desc");
            Superchannel = reader.ReadLong("superchannel");
            SuperchannelDesc = reader.ReadString("superchannel_desc");
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
