// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class MCategoriesCategory : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "category")] public long Category { get; set; }
        [QuerySqlField(Name = "description")] public string Description { get; set; }
        [QuerySqlField(Name = "displayorder")] public long Displayorder { get; set; }
        [QuerySqlField(Name = "name")] public string Name { get; set; }
        [QuerySqlField(Name = "shortname")] public string Shortname { get; set; }
        [QuerySqlField(Name = "startrange")] public double Startrange { get; set; }
        [QuerySqlField(Name = "endrange")] public double Endrange { get; set; }
        [QuerySqlField(Name = "supercategory")] public long Supercategory { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong(nameof(Category), Category);
            writer.WriteString(nameof(Description), Description);
            writer.WriteLong(nameof(Displayorder), Displayorder);
            writer.WriteString(nameof(Name), Name);
            writer.WriteString(nameof(Shortname), Shortname);
            writer.WriteDouble(nameof(Startrange), Startrange);
            writer.WriteDouble(nameof(Endrange), Endrange);
            writer.WriteLong(nameof(Supercategory), Supercategory);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Category = reader.ReadLong(nameof(Category));
            Description = reader.ReadString(nameof(Description));
            Displayorder = reader.ReadLong(nameof(Displayorder));
            Name = reader.ReadString(nameof(Name));
            Shortname = reader.ReadString(nameof(Shortname));
            Startrange = reader.ReadDouble(nameof(Startrange));
            Endrange = reader.ReadDouble(nameof(Endrange));
            Supercategory = reader.ReadLong(nameof(Supercategory));
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Category = *(long*) (p + 0);
                Description = Encoding.ASCII.GetString(buffer, 8, 256).TrimEnd();
                Displayorder = *(long*) (p + 264);
                Name = Encoding.ASCII.GetString(buffer, 272, 128).TrimEnd();
                Shortname = Encoding.ASCII.GetString(buffer, 400, 128).TrimEnd();
                Startrange = *(double*) (p + 528);
                Endrange = *(double*) (p + 536);
                Supercategory = *(long*) (p + 544);
            }
        }
    }
}
