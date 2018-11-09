// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AttrPositemsAttributes : IBinarizable, ICanReadFromRecordBuffer, IItemid
    {
        public long Itemid { get; set; }
        [QuerySqlField(Name = "supercategory")] public long Supercategory { get; set; }
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "class")] public long Class { get; set; }
        [QuerySqlField(Name = "category")] public long Category { get; set; }
        [QuerySqlField(Name = "pcarryon")] public long Pcarryon { get; set; }
        [QuerySqlField(Name = "pcasematerial")] public long Pcasematerial { get; set; }
        [QuerySqlField(Name = "pcaseshape")] public long Pcaseshape { get; set; }
        [QuerySqlField(Name = "pchildrens")] public long Pchildrens { get; set; }
        [QuerySqlField(Name = "pchronograph")] public long Pchronograph { get; set; }
        [QuerySqlField(Name = "pdaydate")] public long Pdaydate { get; set; }
        [QuerySqlField(Name = "pevening")] public long Pevening { get; set; }
        [QuerySqlField(Name = "pexpandable")] public long Pexpandable { get; set; }
        [QuerySqlField(Name = "pexternalframe")] public long Pexternalframe { get; set; }
        [QuerySqlField(Name = "pfannypackvolume")] public long Pfannypackvolume { get; set; }
        [QuerySqlField(Name = "pgemstones")] public long Pgemstones { get; set; }
        [QuerySqlField(Name = "phydrationcompatible")] public long Phydrationcompatible { get; set; }
        [QuerySqlField(Name = "phydrationincluded")] public long Phydrationincluded { get; set; }
        [QuerySqlField(Name = "pinterchangeablelenses")] public long Pinterchangeablelenses { get; set; }
        [QuerySqlField(Name = "plaptopsleeve")] public long Plaptopsleeve { get; set; }
        [QuerySqlField(Name = "pluggage")] public long Pluggage { get; set; }
        [QuerySqlField(Name = "pmaterial")] public long Pmaterial { get; set; }
        [QuerySqlField(Name = "pmobilephonesleeve")] public long Pmobilephonesleeve { get; set; }
        [QuerySqlField(Name = "pmultifunctionalmultipu")] public long Pmultifunctionalmultipu { get; set; }
        [QuerySqlField(Name = "pnoband")] public long Pnoband { get; set; }
        [QuerySqlField(Name = "ppackvolume")] public long Ppackvolume { get; set; }
        [QuerySqlField(Name = "pphotogromatic")] public long Pphotogromatic { get; set; }
        [QuerySqlField(Name = "ppolarized")] public long Ppolarized { get; set; }
        [QuerySqlField(Name = "pprimaryanalogdigital")] public long Pprimaryanalogdigital { get; set; }
        [QuerySqlField(Name = "pprimarybandmaterial")] public long Pprimarybandmaterial { get; set; }
        [QuerySqlField(Name = "psaffianoleather")] public long Psaffianoleather { get; set; }
        [QuerySqlField(Name = "psilhouette")] public long Psilhouette { get; set; }
        [QuerySqlField(Name = "psize")] public long Psize { get; set; }
        [QuerySqlField(Name = "pspinners")] public long Pspinners { get; set; }
        [QuerySqlField(Name = "pwalletshape")] public long Pwalletshape { get; set; }
        [QuerySqlField(Name = "pwallettype")] public long Pwallettype { get; set; }
        [QuerySqlField(Name = "pwatchtype")] public long Pwatchtype { get; set; }
        [QuerySqlField(Name = "pwaterproof")] public long Pwaterproof { get; set; }
        [QuerySqlField(Name = "pwaterresistant")] public long Pwaterresistant { get; set; }
        [QuerySqlField(Name = "pwheels")] public long Pwheels { get; set; }
        [QuerySqlField(Name = "pactivity")] public long Pactivity { get; set; }
        [QuerySqlField(Name = "pbandtype")] public long Pbandtype { get; set; }
        [QuerySqlField(Name = "pbatterycharged")] public long Pbatterycharged { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("itemid", Itemid);
            writer.WriteLong("supercategory", Supercategory);
            writer.WriteLong("subclass", Subclass);
            writer.WriteLong("class", Class);
            writer.WriteLong("category", Category);
            writer.WriteLong("pcarryon", Pcarryon);
            writer.WriteLong("pcasematerial", Pcasematerial);
            writer.WriteLong("pcaseshape", Pcaseshape);
            writer.WriteLong("pchildrens", Pchildrens);
            writer.WriteLong("pchronograph", Pchronograph);
            writer.WriteLong("pdaydate", Pdaydate);
            writer.WriteLong("pevening", Pevening);
            writer.WriteLong("pexpandable", Pexpandable);
            writer.WriteLong("pexternalframe", Pexternalframe);
            writer.WriteLong("pfannypackvolume", Pfannypackvolume);
            writer.WriteLong("pgemstones", Pgemstones);
            writer.WriteLong("phydrationcompatible", Phydrationcompatible);
            writer.WriteLong("phydrationincluded", Phydrationincluded);
            writer.WriteLong("pinterchangeablelenses", Pinterchangeablelenses);
            writer.WriteLong("plaptopsleeve", Plaptopsleeve);
            writer.WriteLong("pluggage", Pluggage);
            writer.WriteLong("pmaterial", Pmaterial);
            writer.WriteLong("pmobilephonesleeve", Pmobilephonesleeve);
            writer.WriteLong("pmultifunctionalmultipu", Pmultifunctionalmultipu);
            writer.WriteLong("pnoband", Pnoband);
            writer.WriteLong("ppackvolume", Ppackvolume);
            writer.WriteLong("pphotogromatic", Pphotogromatic);
            writer.WriteLong("ppolarized", Ppolarized);
            writer.WriteLong("pprimaryanalogdigital", Pprimaryanalogdigital);
            writer.WriteLong("pprimarybandmaterial", Pprimarybandmaterial);
            writer.WriteLong("psaffianoleather", Psaffianoleather);
            writer.WriteLong("psilhouette", Psilhouette);
            writer.WriteLong("psize", Psize);
            writer.WriteLong("pspinners", Pspinners);
            writer.WriteLong("pwalletshape", Pwalletshape);
            writer.WriteLong("pwallettype", Pwallettype);
            writer.WriteLong("pwatchtype", Pwatchtype);
            writer.WriteLong("pwaterproof", Pwaterproof);
            writer.WriteLong("pwaterresistant", Pwaterresistant);
            writer.WriteLong("pwheels", Pwheels);
            writer.WriteLong("pactivity", Pactivity);
            writer.WriteLong("pbandtype", Pbandtype);
            writer.WriteLong("pbatterycharged", Pbatterycharged);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Itemid = reader.ReadLong("itemid");
            Supercategory = reader.ReadLong("supercategory");
            Subclass = reader.ReadLong("subclass");
            Class = reader.ReadLong("class");
            Category = reader.ReadLong("category");
            Pcarryon = reader.ReadLong("pcarryon");
            Pcasematerial = reader.ReadLong("pcasematerial");
            Pcaseshape = reader.ReadLong("pcaseshape");
            Pchildrens = reader.ReadLong("pchildrens");
            Pchronograph = reader.ReadLong("pchronograph");
            Pdaydate = reader.ReadLong("pdaydate");
            Pevening = reader.ReadLong("pevening");
            Pexpandable = reader.ReadLong("pexpandable");
            Pexternalframe = reader.ReadLong("pexternalframe");
            Pfannypackvolume = reader.ReadLong("pfannypackvolume");
            Pgemstones = reader.ReadLong("pgemstones");
            Phydrationcompatible = reader.ReadLong("phydrationcompatible");
            Phydrationincluded = reader.ReadLong("phydrationincluded");
            Pinterchangeablelenses = reader.ReadLong("pinterchangeablelenses");
            Plaptopsleeve = reader.ReadLong("plaptopsleeve");
            Pluggage = reader.ReadLong("pluggage");
            Pmaterial = reader.ReadLong("pmaterial");
            Pmobilephonesleeve = reader.ReadLong("pmobilephonesleeve");
            Pmultifunctionalmultipu = reader.ReadLong("pmultifunctionalmultipu");
            Pnoband = reader.ReadLong("pnoband");
            Ppackvolume = reader.ReadLong("ppackvolume");
            Pphotogromatic = reader.ReadLong("pphotogromatic");
            Ppolarized = reader.ReadLong("ppolarized");
            Pprimaryanalogdigital = reader.ReadLong("pprimaryanalogdigital");
            Pprimarybandmaterial = reader.ReadLong("pprimarybandmaterial");
            Psaffianoleather = reader.ReadLong("psaffianoleather");
            Psilhouette = reader.ReadLong("psilhouette");
            Psize = reader.ReadLong("psize");
            Pspinners = reader.ReadLong("pspinners");
            Pwalletshape = reader.ReadLong("pwalletshape");
            Pwallettype = reader.ReadLong("pwallettype");
            Pwatchtype = reader.ReadLong("pwatchtype");
            Pwaterproof = reader.ReadLong("pwaterproof");
            Pwaterresistant = reader.ReadLong("pwaterresistant");
            Pwheels = reader.ReadLong("pwheels");
            Pactivity = reader.ReadLong("pactivity");
            Pbandtype = reader.ReadLong("pbandtype");
            Pbatterycharged = reader.ReadLong("pbatterycharged");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Itemid = *(long*) (p + 0);
                Supercategory = *(long*) (p + 8);
                Subclass = *(long*) (p + 16);
                Class = *(long*) (p + 24);
                Category = *(long*) (p + 32);
                Pcarryon = *(long*) (p + 40);
                Pcasematerial = *(long*) (p + 48);
                Pcaseshape = *(long*) (p + 56);
                Pchildrens = *(long*) (p + 64);
                Pchronograph = *(long*) (p + 72);
                Pdaydate = *(long*) (p + 80);
                Pevening = *(long*) (p + 88);
                Pexpandable = *(long*) (p + 96);
                Pexternalframe = *(long*) (p + 104);
                Pfannypackvolume = *(long*) (p + 112);
                Pgemstones = *(long*) (p + 120);
                Phydrationcompatible = *(long*) (p + 128);
                Phydrationincluded = *(long*) (p + 136);
                Pinterchangeablelenses = *(long*) (p + 144);
                Plaptopsleeve = *(long*) (p + 152);
                Pluggage = *(long*) (p + 160);
                Pmaterial = *(long*) (p + 168);
                Pmobilephonesleeve = *(long*) (p + 176);
                Pmultifunctionalmultipu = *(long*) (p + 184);
                Pnoband = *(long*) (p + 192);
                Ppackvolume = *(long*) (p + 200);
                Pphotogromatic = *(long*) (p + 208);
                Ppolarized = *(long*) (p + 216);
                Pprimaryanalogdigital = *(long*) (p + 224);
                Pprimarybandmaterial = *(long*) (p + 232);
                Psaffianoleather = *(long*) (p + 240);
                Psilhouette = *(long*) (p + 248);
                Psize = *(long*) (p + 256);
                Pspinners = *(long*) (p + 264);
                Pwalletshape = *(long*) (p + 272);
                Pwallettype = *(long*) (p + 280);
                Pwatchtype = *(long*) (p + 288);
                Pwaterproof = *(long*) (p + 296);
                Pwaterresistant = *(long*) (p + 304);
                Pwheels = *(long*) (p + 312);
                Pactivity = *(long*) (p + 320);
                Pbandtype = *(long*) (p + 328);
                Pbatterycharged = *(long*) (p + 336);
            }
        }
    }
}
