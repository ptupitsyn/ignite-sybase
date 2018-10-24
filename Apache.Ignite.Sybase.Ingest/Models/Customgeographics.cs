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
            writer.WriteString(nameof(Postalcode), Postalcode);
            writer.WriteLong(nameof(Abestbuyterritoriescns), Abestbuyterritoriescns);
            writer.WriteLong(nameof(Abjscustomareas), Abjscustomareas);
            writer.WriteLong(nameof(Abjscustomdivisions), Abjscustomdivisions);
            writer.WriteLong(nameof(Aexpocustomregion), Aexpocustomregion);
            writer.WriteLong(nameof(Agfld01), Agfld01);
            writer.WriteLong(nameof(Ahhgreggcustomdivisions), Ahhgreggcustomdivisions);
            writer.WriteLong(nameof(Ahhgreggcustomregions), Ahhgreggcustomregions);
            writer.WriteLong(nameof(Ahhgreggdivisionsandregio), Ahhgreggdivisionsandregio);
            writer.WriteLong(nameof(Ahpdistricts), Ahpdistricts);
            writer.WriteLong(nameof(Akevintest), Akevintest);
            writer.WriteLong(nameof(Akohlsmarketclustertotal), Akohlsmarketclustertotal);
            writer.WriteLong(nameof(Amacyscustomarea), Amacyscustomarea);
            writer.WriteLong(nameof(Amacyscustomdistrict), Amacyscustomdistrict);
            writer.WriteLong(nameof(Amacyscustomregion), Amacyscustomregion);
            writer.WriteLong(nameof(Ameijercustomdivisions), Ameijercustomdivisions);
            writer.WriteLong(nameof(Ameijercustomregions), Ameijercustomregions);
            writer.WriteLong(nameof(Anapadivisions), Anapadivisions);
            writer.WriteLong(nameof(Anaparegions), Anaparegions);
            writer.WriteLong(nameof(Aneeacustomregionlevel2), Aneeacustomregionlevel2);
            writer.WriteLong(nameof(Anielsencty), Anielsencty);
            writer.WriteLong(nameof(Aprogroupregions), Aprogroupregions);
            writer.WriteLong(nameof(Arackroomcustomgeos), Arackroomcustomgeos);
            writer.WriteLong(nameof(Arackroomcustomgeototal), Arackroomcustomgeototal);
            writer.WriteLong(nameof(Asamsclubsubdivisions), Asamsclubsubdivisions);
            writer.WriteLong(nameof(Asamsclubterritory), Asamsclubterritory);
            writer.WriteLong(nameof(Asonycustomregions), Asonycustomregions);
            writer.WriteLong(nameof(Atargethispaniccustomregi), Atargethispaniccustomregi);
            writer.WriteLong(nameof(Atimezone), Atimezone);
            writer.WriteLong(nameof(Atweetercustomregion), Atweetercustomregion);
            writer.WriteLong(nameof(Atweeterdivisions), Atweeterdivisions);
            writer.WriteLong(nameof(Autozonecustomregionsonl), Autozonecustomregionsonl);
            writer.WriteLong(nameof(Autozonedivisionsandregi), Autozonedivisionsandregi);
            writer.WriteLong(nameof(Awalmartcustomdivisions), Awalmartcustomdivisions);
            writer.WriteLong(nameof(Awalmartcustommarkets), Awalmartcustommarkets);
            writer.WriteLong(nameof(Awalmartcustomregions), Awalmartcustomregions);
            writer.WriteLong(nameof(Awalmartgbu), Awalmartgbu);
            writer.WriteLong(nameof(Awalmartterritory), Awalmartterritory);
            writer.WriteLong(nameof(Cbsa), Cbsa);
            writer.WriteLong(nameof(Cbsamarketsize), Cbsamarketsize);
            writer.WriteLong(nameof(Censusdivisionusa), Censusdivisionusa);
            writer.WriteLong(nameof(Censusregionusa), Censusregionusa);
            writer.WriteLong(nameof(Cpmstater), Cpmstater);
            writer.WriteLong(nameof(Cscgeoconsumer), Cscgeoconsumer);
            writer.WriteLong(nameof(Cw1geoconsumer), Cw1geoconsumer);
            writer.WriteLong(nameof(Dma), Dma);
            writer.WriteLong(nameof(Fipscounty), Fipscounty);
            writer.WriteLong(nameof(Hpcustomregions), Hpcustomregions);
            writer.WriteLong(nameof(Hpdivisions), Hpdivisions);
            writer.WriteLong(nameof(Kohlsmarketclusters), Kohlsmarketclusters);
            writer.WriteLong(nameof(Marketsize), Marketsize);
            writer.WriteLong(nameof(Msa), Msa);
            writer.WriteLong(nameof(Neeacustomregionlevel1), Neeacustomregionlevel1);
            writer.WriteLong(nameof(Pgmsa), Pgmsa);
            writer.WriteLong(nameof(Abestbuycustompricinggeos), Abestbuycustompricinggeos);
            writer.WriteLong(nameof(State), State);
            writer.WriteLong(nameof(Tweeterregionsanddivisio), Tweeterregionsanddivisio);
            writer.WriteLong(nameof(Abestbuydistrictscns), Abestbuydistrictscns);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Postalcode = reader.ReadString(nameof(Postalcode));
            Abestbuyterritoriescns = reader.ReadLong(nameof(Abestbuyterritoriescns));
            Abjscustomareas = reader.ReadLong(nameof(Abjscustomareas));
            Abjscustomdivisions = reader.ReadLong(nameof(Abjscustomdivisions));
            Aexpocustomregion = reader.ReadLong(nameof(Aexpocustomregion));
            Agfld01 = reader.ReadLong(nameof(Agfld01));
            Ahhgreggcustomdivisions = reader.ReadLong(nameof(Ahhgreggcustomdivisions));
            Ahhgreggcustomregions = reader.ReadLong(nameof(Ahhgreggcustomregions));
            Ahhgreggdivisionsandregio = reader.ReadLong(nameof(Ahhgreggdivisionsandregio));
            Ahpdistricts = reader.ReadLong(nameof(Ahpdistricts));
            Akevintest = reader.ReadLong(nameof(Akevintest));
            Akohlsmarketclustertotal = reader.ReadLong(nameof(Akohlsmarketclustertotal));
            Amacyscustomarea = reader.ReadLong(nameof(Amacyscustomarea));
            Amacyscustomdistrict = reader.ReadLong(nameof(Amacyscustomdistrict));
            Amacyscustomregion = reader.ReadLong(nameof(Amacyscustomregion));
            Ameijercustomdivisions = reader.ReadLong(nameof(Ameijercustomdivisions));
            Ameijercustomregions = reader.ReadLong(nameof(Ameijercustomregions));
            Anapadivisions = reader.ReadLong(nameof(Anapadivisions));
            Anaparegions = reader.ReadLong(nameof(Anaparegions));
            Aneeacustomregionlevel2 = reader.ReadLong(nameof(Aneeacustomregionlevel2));
            Anielsencty = reader.ReadLong(nameof(Anielsencty));
            Aprogroupregions = reader.ReadLong(nameof(Aprogroupregions));
            Arackroomcustomgeos = reader.ReadLong(nameof(Arackroomcustomgeos));
            Arackroomcustomgeototal = reader.ReadLong(nameof(Arackroomcustomgeototal));
            Asamsclubsubdivisions = reader.ReadLong(nameof(Asamsclubsubdivisions));
            Asamsclubterritory = reader.ReadLong(nameof(Asamsclubterritory));
            Asonycustomregions = reader.ReadLong(nameof(Asonycustomregions));
            Atargethispaniccustomregi = reader.ReadLong(nameof(Atargethispaniccustomregi));
            Atimezone = reader.ReadLong(nameof(Atimezone));
            Atweetercustomregion = reader.ReadLong(nameof(Atweetercustomregion));
            Atweeterdivisions = reader.ReadLong(nameof(Atweeterdivisions));
            Autozonecustomregionsonl = reader.ReadLong(nameof(Autozonecustomregionsonl));
            Autozonedivisionsandregi = reader.ReadLong(nameof(Autozonedivisionsandregi));
            Awalmartcustomdivisions = reader.ReadLong(nameof(Awalmartcustomdivisions));
            Awalmartcustommarkets = reader.ReadLong(nameof(Awalmartcustommarkets));
            Awalmartcustomregions = reader.ReadLong(nameof(Awalmartcustomregions));
            Awalmartgbu = reader.ReadLong(nameof(Awalmartgbu));
            Awalmartterritory = reader.ReadLong(nameof(Awalmartterritory));
            Cbsa = reader.ReadLong(nameof(Cbsa));
            Cbsamarketsize = reader.ReadLong(nameof(Cbsamarketsize));
            Censusdivisionusa = reader.ReadLong(nameof(Censusdivisionusa));
            Censusregionusa = reader.ReadLong(nameof(Censusregionusa));
            Cpmstater = reader.ReadLong(nameof(Cpmstater));
            Cscgeoconsumer = reader.ReadLong(nameof(Cscgeoconsumer));
            Cw1geoconsumer = reader.ReadLong(nameof(Cw1geoconsumer));
            Dma = reader.ReadLong(nameof(Dma));
            Fipscounty = reader.ReadLong(nameof(Fipscounty));
            Hpcustomregions = reader.ReadLong(nameof(Hpcustomregions));
            Hpdivisions = reader.ReadLong(nameof(Hpdivisions));
            Kohlsmarketclusters = reader.ReadLong(nameof(Kohlsmarketclusters));
            Marketsize = reader.ReadLong(nameof(Marketsize));
            Msa = reader.ReadLong(nameof(Msa));
            Neeacustomregionlevel1 = reader.ReadLong(nameof(Neeacustomregionlevel1));
            Pgmsa = reader.ReadLong(nameof(Pgmsa));
            Abestbuycustompricinggeos = reader.ReadLong(nameof(Abestbuycustompricinggeos));
            State = reader.ReadLong(nameof(State));
            Tweeterregionsanddivisio = reader.ReadLong(nameof(Tweeterregionsanddivisio));
            Abestbuydistrictscns = reader.ReadLong(nameof(Abestbuydistrictscns));
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
