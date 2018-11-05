// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class Customgeographics : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "postalcode")] public string Postalcode { get; set; }
        [QuerySqlField(Name = "abestbuyterritoriescns")] public long Abestbuyterritoriescns { get; set; }
        [QuerySqlField(Name = "abjscustomareas")] public long Abjscustomareas { get; set; }
        [QuerySqlField(Name = "abjscustomdivisions")] public long Abjscustomdivisions { get; set; }
        [QuerySqlField(Name = "aexpocustomregion")] public long Aexpocustomregion { get; set; }
        [QuerySqlField(Name = "agfld01")] public long Agfld01 { get; set; }
        [QuerySqlField(Name = "ahhgreggcustomdivisions")] public long Ahhgreggcustomdivisions { get; set; }
        [QuerySqlField(Name = "ahhgreggcustomregions")] public long Ahhgreggcustomregions { get; set; }
        [QuerySqlField(Name = "ahhgreggdivisionsandregio")] public long Ahhgreggdivisionsandregio { get; set; }
        [QuerySqlField(Name = "ahpdistricts")] public long Ahpdistricts { get; set; }
        [QuerySqlField(Name = "akevintest")] public long Akevintest { get; set; }
        [QuerySqlField(Name = "akohlsmarketclustertotal")] public long Akohlsmarketclustertotal { get; set; }
        [QuerySqlField(Name = "amacyscustomarea")] public long Amacyscustomarea { get; set; }
        [QuerySqlField(Name = "amacyscustomdistrict")] public long Amacyscustomdistrict { get; set; }
        [QuerySqlField(Name = "amacyscustomregion")] public long Amacyscustomregion { get; set; }
        [QuerySqlField(Name = "ameijercustomdivisions")] public long Ameijercustomdivisions { get; set; }
        [QuerySqlField(Name = "ameijercustomregions")] public long Ameijercustomregions { get; set; }
        [QuerySqlField(Name = "anapadivisions")] public long Anapadivisions { get; set; }
        [QuerySqlField(Name = "anaparegions")] public long Anaparegions { get; set; }
        [QuerySqlField(Name = "aneeacustomregionlevel2")] public long Aneeacustomregionlevel2 { get; set; }
        [QuerySqlField(Name = "anielsencty")] public long Anielsencty { get; set; }
        [QuerySqlField(Name = "aprogroupregions")] public long Aprogroupregions { get; set; }
        [QuerySqlField(Name = "arackroomcustomgeos")] public long Arackroomcustomgeos { get; set; }
        [QuerySqlField(Name = "arackroomcustomgeototal")] public long Arackroomcustomgeototal { get; set; }
        [QuerySqlField(Name = "asamsclubsubdivisions")] public long Asamsclubsubdivisions { get; set; }
        [QuerySqlField(Name = "asamsclubterritory")] public long Asamsclubterritory { get; set; }
        [QuerySqlField(Name = "asonycustomregions")] public long Asonycustomregions { get; set; }
        [QuerySqlField(Name = "atargethispaniccustomregi")] public long Atargethispaniccustomregi { get; set; }
        [QuerySqlField(Name = "atimezone")] public long Atimezone { get; set; }
        [QuerySqlField(Name = "atweetercustomregion")] public long Atweetercustomregion { get; set; }
        [QuerySqlField(Name = "atweeterdivisions")] public long Atweeterdivisions { get; set; }
        [QuerySqlField(Name = "autozonecustomregionsonl")] public long Autozonecustomregionsonl { get; set; }
        [QuerySqlField(Name = "autozonedivisionsandregi")] public long Autozonedivisionsandregi { get; set; }
        [QuerySqlField(Name = "awalmartcustomdivisions")] public long Awalmartcustomdivisions { get; set; }
        [QuerySqlField(Name = "awalmartcustommarkets")] public long Awalmartcustommarkets { get; set; }
        [QuerySqlField(Name = "awalmartcustomregions")] public long Awalmartcustomregions { get; set; }
        [QuerySqlField(Name = "awalmartgbu")] public long Awalmartgbu { get; set; }
        [QuerySqlField(Name = "awalmartterritory")] public long Awalmartterritory { get; set; }
        [QuerySqlField(Name = "cbsa")] public long Cbsa { get; set; }
        [QuerySqlField(Name = "cbsamarketsize")] public long Cbsamarketsize { get; set; }
        [QuerySqlField(Name = "censusdivisionusa")] public long Censusdivisionusa { get; set; }
        [QuerySqlField(Name = "censusregionusa")] public long Censusregionusa { get; set; }
        [QuerySqlField(Name = "cpmstater")] public long Cpmstater { get; set; }
        [QuerySqlField(Name = "cscgeoconsumer")] public long Cscgeoconsumer { get; set; }
        [QuerySqlField(Name = "cw1geoconsumer")] public long Cw1geoconsumer { get; set; }
        [QuerySqlField(Name = "dma")] public long Dma { get; set; }
        [QuerySqlField(Name = "fipscounty")] public long Fipscounty { get; set; }
        [QuerySqlField(Name = "hpcustomregions")] public long Hpcustomregions { get; set; }
        [QuerySqlField(Name = "hpdivisions")] public long Hpdivisions { get; set; }
        [QuerySqlField(Name = "kohlsmarketclusters")] public long Kohlsmarketclusters { get; set; }
        [QuerySqlField(Name = "marketsize")] public long Marketsize { get; set; }
        [QuerySqlField(Name = "msa")] public long Msa { get; set; }
        [QuerySqlField(Name = "neeacustomregionlevel1")] public long Neeacustomregionlevel1 { get; set; }
        [QuerySqlField(Name = "pgmsa")] public long Pgmsa { get; set; }
        [QuerySqlField(Name = "abestbuycustompricinggeos")] public long Abestbuycustompricinggeos { get; set; }
        [QuerySqlField(Name = "state")] public long State { get; set; }
        [QuerySqlField(Name = "tweeterregionsanddivisio")] public long Tweeterregionsanddivisio { get; set; }
        [QuerySqlField(Name = "abestbuydistrictscns")] public long Abestbuydistrictscns { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteString("postalcode", Postalcode);
            writer.WriteLong("abestbuyterritoriescns", Abestbuyterritoriescns);
            writer.WriteLong("abjscustomareas", Abjscustomareas);
            writer.WriteLong("abjscustomdivisions", Abjscustomdivisions);
            writer.WriteLong("aexpocustomregion", Aexpocustomregion);
            writer.WriteLong("agfld01", Agfld01);
            writer.WriteLong("ahhgreggcustomdivisions", Ahhgreggcustomdivisions);
            writer.WriteLong("ahhgreggcustomregions", Ahhgreggcustomregions);
            writer.WriteLong("ahhgreggdivisionsandregio", Ahhgreggdivisionsandregio);
            writer.WriteLong("ahpdistricts", Ahpdistricts);
            writer.WriteLong("akevintest", Akevintest);
            writer.WriteLong("akohlsmarketclustertotal", Akohlsmarketclustertotal);
            writer.WriteLong("amacyscustomarea", Amacyscustomarea);
            writer.WriteLong("amacyscustomdistrict", Amacyscustomdistrict);
            writer.WriteLong("amacyscustomregion", Amacyscustomregion);
            writer.WriteLong("ameijercustomdivisions", Ameijercustomdivisions);
            writer.WriteLong("ameijercustomregions", Ameijercustomregions);
            writer.WriteLong("anapadivisions", Anapadivisions);
            writer.WriteLong("anaparegions", Anaparegions);
            writer.WriteLong("aneeacustomregionlevel2", Aneeacustomregionlevel2);
            writer.WriteLong("anielsencty", Anielsencty);
            writer.WriteLong("aprogroupregions", Aprogroupregions);
            writer.WriteLong("arackroomcustomgeos", Arackroomcustomgeos);
            writer.WriteLong("arackroomcustomgeototal", Arackroomcustomgeototal);
            writer.WriteLong("asamsclubsubdivisions", Asamsclubsubdivisions);
            writer.WriteLong("asamsclubterritory", Asamsclubterritory);
            writer.WriteLong("asonycustomregions", Asonycustomregions);
            writer.WriteLong("atargethispaniccustomregi", Atargethispaniccustomregi);
            writer.WriteLong("atimezone", Atimezone);
            writer.WriteLong("atweetercustomregion", Atweetercustomregion);
            writer.WriteLong("atweeterdivisions", Atweeterdivisions);
            writer.WriteLong("autozonecustomregionsonl", Autozonecustomregionsonl);
            writer.WriteLong("autozonedivisionsandregi", Autozonedivisionsandregi);
            writer.WriteLong("awalmartcustomdivisions", Awalmartcustomdivisions);
            writer.WriteLong("awalmartcustommarkets", Awalmartcustommarkets);
            writer.WriteLong("awalmartcustomregions", Awalmartcustomregions);
            writer.WriteLong("awalmartgbu", Awalmartgbu);
            writer.WriteLong("awalmartterritory", Awalmartterritory);
            writer.WriteLong("cbsa", Cbsa);
            writer.WriteLong("cbsamarketsize", Cbsamarketsize);
            writer.WriteLong("censusdivisionusa", Censusdivisionusa);
            writer.WriteLong("censusregionusa", Censusregionusa);
            writer.WriteLong("cpmstater", Cpmstater);
            writer.WriteLong("cscgeoconsumer", Cscgeoconsumer);
            writer.WriteLong("cw1geoconsumer", Cw1geoconsumer);
            writer.WriteLong("dma", Dma);
            writer.WriteLong("fipscounty", Fipscounty);
            writer.WriteLong("hpcustomregions", Hpcustomregions);
            writer.WriteLong("hpdivisions", Hpdivisions);
            writer.WriteLong("kohlsmarketclusters", Kohlsmarketclusters);
            writer.WriteLong("marketsize", Marketsize);
            writer.WriteLong("msa", Msa);
            writer.WriteLong("neeacustomregionlevel1", Neeacustomregionlevel1);
            writer.WriteLong("pgmsa", Pgmsa);
            writer.WriteLong("abestbuycustompricinggeos", Abestbuycustompricinggeos);
            writer.WriteLong("state", State);
            writer.WriteLong("tweeterregionsanddivisio", Tweeterregionsanddivisio);
            writer.WriteLong("abestbuydistrictscns", Abestbuydistrictscns);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Postalcode = reader.ReadString("postalcode");
            Abestbuyterritoriescns = reader.ReadLong("abestbuyterritoriescns");
            Abjscustomareas = reader.ReadLong("abjscustomareas");
            Abjscustomdivisions = reader.ReadLong("abjscustomdivisions");
            Aexpocustomregion = reader.ReadLong("aexpocustomregion");
            Agfld01 = reader.ReadLong("agfld01");
            Ahhgreggcustomdivisions = reader.ReadLong("ahhgreggcustomdivisions");
            Ahhgreggcustomregions = reader.ReadLong("ahhgreggcustomregions");
            Ahhgreggdivisionsandregio = reader.ReadLong("ahhgreggdivisionsandregio");
            Ahpdistricts = reader.ReadLong("ahpdistricts");
            Akevintest = reader.ReadLong("akevintest");
            Akohlsmarketclustertotal = reader.ReadLong("akohlsmarketclustertotal");
            Amacyscustomarea = reader.ReadLong("amacyscustomarea");
            Amacyscustomdistrict = reader.ReadLong("amacyscustomdistrict");
            Amacyscustomregion = reader.ReadLong("amacyscustomregion");
            Ameijercustomdivisions = reader.ReadLong("ameijercustomdivisions");
            Ameijercustomregions = reader.ReadLong("ameijercustomregions");
            Anapadivisions = reader.ReadLong("anapadivisions");
            Anaparegions = reader.ReadLong("anaparegions");
            Aneeacustomregionlevel2 = reader.ReadLong("aneeacustomregionlevel2");
            Anielsencty = reader.ReadLong("anielsencty");
            Aprogroupregions = reader.ReadLong("aprogroupregions");
            Arackroomcustomgeos = reader.ReadLong("arackroomcustomgeos");
            Arackroomcustomgeototal = reader.ReadLong("arackroomcustomgeototal");
            Asamsclubsubdivisions = reader.ReadLong("asamsclubsubdivisions");
            Asamsclubterritory = reader.ReadLong("asamsclubterritory");
            Asonycustomregions = reader.ReadLong("asonycustomregions");
            Atargethispaniccustomregi = reader.ReadLong("atargethispaniccustomregi");
            Atimezone = reader.ReadLong("atimezone");
            Atweetercustomregion = reader.ReadLong("atweetercustomregion");
            Atweeterdivisions = reader.ReadLong("atweeterdivisions");
            Autozonecustomregionsonl = reader.ReadLong("autozonecustomregionsonl");
            Autozonedivisionsandregi = reader.ReadLong("autozonedivisionsandregi");
            Awalmartcustomdivisions = reader.ReadLong("awalmartcustomdivisions");
            Awalmartcustommarkets = reader.ReadLong("awalmartcustommarkets");
            Awalmartcustomregions = reader.ReadLong("awalmartcustomregions");
            Awalmartgbu = reader.ReadLong("awalmartgbu");
            Awalmartterritory = reader.ReadLong("awalmartterritory");
            Cbsa = reader.ReadLong("cbsa");
            Cbsamarketsize = reader.ReadLong("cbsamarketsize");
            Censusdivisionusa = reader.ReadLong("censusdivisionusa");
            Censusregionusa = reader.ReadLong("censusregionusa");
            Cpmstater = reader.ReadLong("cpmstater");
            Cscgeoconsumer = reader.ReadLong("cscgeoconsumer");
            Cw1geoconsumer = reader.ReadLong("cw1geoconsumer");
            Dma = reader.ReadLong("dma");
            Fipscounty = reader.ReadLong("fipscounty");
            Hpcustomregions = reader.ReadLong("hpcustomregions");
            Hpdivisions = reader.ReadLong("hpdivisions");
            Kohlsmarketclusters = reader.ReadLong("kohlsmarketclusters");
            Marketsize = reader.ReadLong("marketsize");
            Msa = reader.ReadLong("msa");
            Neeacustomregionlevel1 = reader.ReadLong("neeacustomregionlevel1");
            Pgmsa = reader.ReadLong("pgmsa");
            Abestbuycustompricinggeos = reader.ReadLong("abestbuycustompricinggeos");
            State = reader.ReadLong("state");
            Tweeterregionsanddivisio = reader.ReadLong("tweeterregionsanddivisio");
            Abestbuydistrictscns = reader.ReadLong("abestbuydistrictscns");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Postalcode = Encoding.ASCII.GetString(buffer, 0, 20).TrimEnd();
                Abestbuyterritoriescns = *(long*) (p + 20);
                Abjscustomareas = *(long*) (p + 28);
                Abjscustomdivisions = *(long*) (p + 36);
                Aexpocustomregion = *(long*) (p + 44);
                Agfld01 = *(long*) (p + 52);
                Ahhgreggcustomdivisions = *(long*) (p + 60);
                Ahhgreggcustomregions = *(long*) (p + 68);
                Ahhgreggdivisionsandregio = *(long*) (p + 76);
                Ahpdistricts = *(long*) (p + 84);
                Akevintest = *(long*) (p + 92);
                Akohlsmarketclustertotal = *(long*) (p + 100);
                Amacyscustomarea = *(long*) (p + 108);
                Amacyscustomdistrict = *(long*) (p + 116);
                Amacyscustomregion = *(long*) (p + 124);
                Ameijercustomdivisions = *(long*) (p + 132);
                Ameijercustomregions = *(long*) (p + 140);
                Anapadivisions = *(long*) (p + 148);
                Anaparegions = *(long*) (p + 156);
                Aneeacustomregionlevel2 = *(long*) (p + 164);
                Anielsencty = *(long*) (p + 172);
                Aprogroupregions = *(long*) (p + 180);
                Arackroomcustomgeos = *(long*) (p + 188);
                Arackroomcustomgeototal = *(long*) (p + 196);
                Asamsclubsubdivisions = *(long*) (p + 204);
                Asamsclubterritory = *(long*) (p + 212);
                Asonycustomregions = *(long*) (p + 220);
                Atargethispaniccustomregi = *(long*) (p + 228);
                Atimezone = *(long*) (p + 236);
                Atweetercustomregion = *(long*) (p + 244);
                Atweeterdivisions = *(long*) (p + 252);
                Autozonecustomregionsonl = *(long*) (p + 260);
                Autozonedivisionsandregi = *(long*) (p + 268);
                Awalmartcustomdivisions = *(long*) (p + 276);
                Awalmartcustommarkets = *(long*) (p + 284);
                Awalmartcustomregions = *(long*) (p + 292);
                Awalmartgbu = *(long*) (p + 300);
                Awalmartterritory = *(long*) (p + 308);
                Cbsa = *(long*) (p + 316);
                Cbsamarketsize = *(long*) (p + 324);
                Censusdivisionusa = *(long*) (p + 332);
                Censusregionusa = *(long*) (p + 340);
                Cpmstater = *(long*) (p + 348);
                Cscgeoconsumer = *(long*) (p + 356);
                Cw1geoconsumer = *(long*) (p + 364);
                Dma = *(long*) (p + 372);
                Fipscounty = *(long*) (p + 380);
                Hpcustomregions = *(long*) (p + 388);
                Hpdivisions = *(long*) (p + 396);
                Kohlsmarketclusters = *(long*) (p + 404);
                Marketsize = *(long*) (p + 412);
                Msa = *(long*) (p + 420);
                Neeacustomregionlevel1 = *(long*) (p + 428);
                Pgmsa = *(long*) (p + 436);
                Abestbuycustompricinggeos = *(long*) (p + 444);
                State = *(long*) (p + 452);
                Tweeterregionsanddivisio = *(long*) (p + 460);
                Abestbuydistrictscns = *(long*) (p + 468);
            }
        }
    }
}
