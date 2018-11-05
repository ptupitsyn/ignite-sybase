// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AttrAttributesLookup : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "attribute_dependent_codeset")] public string AttributeDependentCodeset { get; set; }
        [QuerySqlField(Name = "attribute_name")] public string AttributeName { get; set; }
        [QuerySqlField(Name = "code")] public long Code { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }
        [QuerySqlField(Name = "sbname")] public string Sbname { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString("attribute_dependent_codeset", AttributeDependentCodeset);
            writer.WriteString("attribute_name", AttributeName);
            writer.WriteLong("code", Code);
            writer.WriteString("description", Description);
            writer.WriteLong("displayorder", Displayorder);
            writer.WriteDouble("startrange", Startrange);
            writer.WriteDouble("endrange", Endrange);
            writer.WriteString("sbname", Sbname);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            AttributeDependentCodeset = reader.ReadString("attribute_dependent_codeset");
            AttributeName = reader.ReadString("attribute_name");
            Code = reader.ReadLong("code");
            Description = reader.ReadString("description");
            Displayorder = reader.ReadLong("displayorder");
            Startrange = reader.ReadDouble("startrange");
            Endrange = reader.ReadDouble("endrange");
            Sbname = reader.ReadString("sbname");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                AttributeDependentCodeset = Encoding.ASCII.GetString(buffer, 0, 128).TrimEnd();
                AttributeName = Encoding.ASCII.GetString(buffer, 128, 128).TrimEnd();
                Code = *(long*) (p + 256);
                Description = Encoding.ASCII.GetString(buffer, 264, 128).TrimEnd();
                Displayorder = *(long*) (p + 392);
                Startrange = *(double*) (p + 400);
                Endrange = *(double*) (p + 408);
                Sbname = Encoding.ASCII.GetString(buffer, 416, 30).TrimEnd();
            }
        }
    }
}
