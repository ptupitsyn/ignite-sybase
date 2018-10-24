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
            writer.WriteString(nameof(AttributeDependentCodeset), AttributeDependentCodeset);
            writer.WriteString(nameof(AttributeName), AttributeName);
            writer.WriteLong(nameof(Code), Code);
            writer.WriteString(nameof(Description), Description);
            writer.WriteLong(nameof(Displayorder), Displayorder);
            writer.WriteDouble(nameof(Startrange), Startrange);
            writer.WriteDouble(nameof(Endrange), Endrange);
            writer.WriteString(nameof(Sbname), Sbname);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            AttributeDependentCodeset = reader.ReadString(nameof(AttributeDependentCodeset));
            AttributeName = reader.ReadString(nameof(AttributeName));
            Code = reader.ReadLong(nameof(Code));
            Description = reader.ReadString(nameof(Description));
            Displayorder = reader.ReadLong(nameof(Displayorder));
            Startrange = reader.ReadDouble(nameof(Startrange));
            Endrange = reader.ReadDouble(nameof(Endrange));
            Sbname = reader.ReadString(nameof(Sbname));
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
