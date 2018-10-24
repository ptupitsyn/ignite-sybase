// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AttrPositemsAttributes : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "itemid")] public long Itemid { get; set; }
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
            writer.WriteLong(nameof(Itemid), Itemid);
            writer.WriteLong(nameof(Supercategory), Supercategory);
            writer.WriteLong(nameof(Subclass), Subclass);
            writer.WriteLong(nameof(Class), Class);
            writer.WriteLong(nameof(Category), Category);
            writer.WriteLong(nameof(Pcarryon), Pcarryon);
            writer.WriteLong(nameof(Pcasematerial), Pcasematerial);
            writer.WriteLong(nameof(Pcaseshape), Pcaseshape);
            writer.WriteLong(nameof(Pchildrens), Pchildrens);
            writer.WriteLong(nameof(Pchronograph), Pchronograph);
            writer.WriteLong(nameof(Pdaydate), Pdaydate);
            writer.WriteLong(nameof(Pevening), Pevening);
            writer.WriteLong(nameof(Pexpandable), Pexpandable);
            writer.WriteLong(nameof(Pexternalframe), Pexternalframe);
            writer.WriteLong(nameof(Pfannypackvolume), Pfannypackvolume);
            writer.WriteLong(nameof(Pgemstones), Pgemstones);
            writer.WriteLong(nameof(Phydrationcompatible), Phydrationcompatible);
            writer.WriteLong(nameof(Phydrationincluded), Phydrationincluded);
            writer.WriteLong(nameof(Pinterchangeablelenses), Pinterchangeablelenses);
            writer.WriteLong(nameof(Plaptopsleeve), Plaptopsleeve);
            writer.WriteLong(nameof(Pluggage), Pluggage);
            writer.WriteLong(nameof(Pmaterial), Pmaterial);
            writer.WriteLong(nameof(Pmobilephonesleeve), Pmobilephonesleeve);
            writer.WriteLong(nameof(Pmultifunctionalmultipu), Pmultifunctionalmultipu);
            writer.WriteLong(nameof(Pnoband), Pnoband);
            writer.WriteLong(nameof(Ppackvolume), Ppackvolume);
            writer.WriteLong(nameof(Pphotogromatic), Pphotogromatic);
            writer.WriteLong(nameof(Ppolarized), Ppolarized);
            writer.WriteLong(nameof(Pprimaryanalogdigital), Pprimaryanalogdigital);
            writer.WriteLong(nameof(Pprimarybandmaterial), Pprimarybandmaterial);
            writer.WriteLong(nameof(Psaffianoleather), Psaffianoleather);
            writer.WriteLong(nameof(Psilhouette), Psilhouette);
            writer.WriteLong(nameof(Psize), Psize);
            writer.WriteLong(nameof(Pspinners), Pspinners);
            writer.WriteLong(nameof(Pwalletshape), Pwalletshape);
            writer.WriteLong(nameof(Pwallettype), Pwallettype);
            writer.WriteLong(nameof(Pwatchtype), Pwatchtype);
            writer.WriteLong(nameof(Pwaterproof), Pwaterproof);
            writer.WriteLong(nameof(Pwaterresistant), Pwaterresistant);
            writer.WriteLong(nameof(Pwheels), Pwheels);
            writer.WriteLong(nameof(Pactivity), Pactivity);
            writer.WriteLong(nameof(Pbandtype), Pbandtype);
            writer.WriteLong(nameof(Pbatterycharged), Pbatterycharged);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Itemid = reader.ReadLong(nameof(Itemid));
            Supercategory = reader.ReadLong(nameof(Supercategory));
            Subclass = reader.ReadLong(nameof(Subclass));
            Class = reader.ReadLong(nameof(Class));
            Category = reader.ReadLong(nameof(Category));
            Pcarryon = reader.ReadLong(nameof(Pcarryon));
            Pcasematerial = reader.ReadLong(nameof(Pcasematerial));
            Pcaseshape = reader.ReadLong(nameof(Pcaseshape));
            Pchildrens = reader.ReadLong(nameof(Pchildrens));
            Pchronograph = reader.ReadLong(nameof(Pchronograph));
            Pdaydate = reader.ReadLong(nameof(Pdaydate));
            Pevening = reader.ReadLong(nameof(Pevening));
            Pexpandable = reader.ReadLong(nameof(Pexpandable));
            Pexternalframe = reader.ReadLong(nameof(Pexternalframe));
            Pfannypackvolume = reader.ReadLong(nameof(Pfannypackvolume));
            Pgemstones = reader.ReadLong(nameof(Pgemstones));
            Phydrationcompatible = reader.ReadLong(nameof(Phydrationcompatible));
            Phydrationincluded = reader.ReadLong(nameof(Phydrationincluded));
            Pinterchangeablelenses = reader.ReadLong(nameof(Pinterchangeablelenses));
            Plaptopsleeve = reader.ReadLong(nameof(Plaptopsleeve));
            Pluggage = reader.ReadLong(nameof(Pluggage));
            Pmaterial = reader.ReadLong(nameof(Pmaterial));
            Pmobilephonesleeve = reader.ReadLong(nameof(Pmobilephonesleeve));
            Pmultifunctionalmultipu = reader.ReadLong(nameof(Pmultifunctionalmultipu));
            Pnoband = reader.ReadLong(nameof(Pnoband));
            Ppackvolume = reader.ReadLong(nameof(Ppackvolume));
            Pphotogromatic = reader.ReadLong(nameof(Pphotogromatic));
            Ppolarized = reader.ReadLong(nameof(Ppolarized));
            Pprimaryanalogdigital = reader.ReadLong(nameof(Pprimaryanalogdigital));
            Pprimarybandmaterial = reader.ReadLong(nameof(Pprimarybandmaterial));
            Psaffianoleather = reader.ReadLong(nameof(Psaffianoleather));
            Psilhouette = reader.ReadLong(nameof(Psilhouette));
            Psize = reader.ReadLong(nameof(Psize));
            Pspinners = reader.ReadLong(nameof(Pspinners));
            Pwalletshape = reader.ReadLong(nameof(Pwalletshape));
            Pwallettype = reader.ReadLong(nameof(Pwallettype));
            Pwatchtype = reader.ReadLong(nameof(Pwatchtype));
            Pwaterproof = reader.ReadLong(nameof(Pwaterproof));
            Pwaterresistant = reader.ReadLong(nameof(Pwaterresistant));
            Pwheels = reader.ReadLong(nameof(Pwheels));
            Pactivity = reader.ReadLong(nameof(Pactivity));
            Pbandtype = reader.ReadLong(nameof(Pbandtype));
            Pbatterycharged = reader.ReadLong(nameof(Pbatterycharged));
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
