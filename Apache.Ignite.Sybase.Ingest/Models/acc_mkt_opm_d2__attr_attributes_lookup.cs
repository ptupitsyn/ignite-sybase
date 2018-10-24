// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class acc_mkt_opm_d2__attr_attributes_lookup : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField] public string attribute_dependent_codeset { get; set; }
        [QuerySqlField] public string attribute_name { get; set; }
        [QuerySqlField] public long code { get; set; }
        [QuerySqlField] public string description { get; set; }
        [QuerySqlField] public long displayorder { get; set; }
        [QuerySqlField] public double startrange { get; set; }
        [QuerySqlField] public double endrange { get; set; }
        [QuerySqlField] public string sbname { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString(nameof(attribute_dependent_codeset), attribute_dependent_codeset);
            writer.WriteString(nameof(attribute_name), attribute_name);
            writer.WriteLong(nameof(code), code);
            writer.WriteString(nameof(description), description);
            writer.WriteLong(nameof(displayorder), displayorder);
            writer.WriteDouble(nameof(startrange), startrange);
            writer.WriteDouble(nameof(endrange), endrange);
            writer.WriteString(nameof(sbname), sbname);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            attribute_dependent_codeset = reader.ReadString(nameof(attribute_dependent_codeset));
            attribute_name = reader.ReadString(nameof(attribute_name));
            code = reader.ReadLong(nameof(code));
            description = reader.ReadString(nameof(description));
            displayorder = reader.ReadLong(nameof(displayorder));
            startrange = reader.ReadDouble(nameof(startrange));
            endrange = reader.ReadDouble(nameof(endrange));
            sbname = reader.ReadString(nameof(sbname));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                attribute_dependent_codeset = Encoding.ASCII.GetString(buffer, 0, 128).TrimEnd();
                attribute_name = Encoding.ASCII.GetString(buffer, 128, 128).TrimEnd();
                code = *(long*) (p + 256);
                description = Encoding.ASCII.GetString(buffer, 264, 128).TrimEnd();
                displayorder = *(long*) (p + 392);
                startrange = *(double*) (p + 400);
                endrange = *(double*) (p + 408);
                sbname = Encoding.ASCII.GetString(buffer, 416, 30).TrimEnd();
            }
        }
    }
}
