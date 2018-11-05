// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AggrDataBrandMon : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "ppmonth")] public long Ppmonth { get; set; }
        [QuerySqlField(Name = "ppweek")] public long Ppweek { get; set; }
        [QuerySqlField(Name = "distributor")] public long Distributor { get; set; }
        [QuerySqlField(Name = "posoutlet")] public long Posoutlet { get; set; }
        [QuerySqlField(Name = "storeid")] public string Storeid { get; set; }
        [QuerySqlField(Name = "postalcode")] public string Postalcode { get; set; }
        [QuerySqlField(Name = "outletstoreid")] public string Outletstoreid { get; set; }
        [QuerySqlField(Name = "loadid")] public long Loadid { get; set; }
        [QuerySqlField(Name = "dma")] public long Dma { get; set; }
        [QuerySqlField(Name = "year")] public long Year { get; set; }
        [QuerySqlField(Name = "yearhalf")] public long Yearhalf { get; set; }
        [QuerySqlField(Name = "yearqtr")] public long Yearqtr { get; set; }
        [QuerySqlField(Name = "yearmonth")] public long Yearmonth { get; set; }
        [QuerySqlField(Name = "yearweek")] public long Yearweek { get; set; }
        [QuerySqlField(Name = "supercategory")] public long Supercategory { get; set; }
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "category")] public long Category { get; set; }
        [QuerySqlField(Name = "categorytype")] public long Categorytype { get; set; }
        [QuerySqlField(Name = "brand")] public long Brand { get; set; }
        [QuerySqlField(Name = "brandfamily")] public long Brandfamily { get; set; }
        [QuerySqlField(Name = "channel")] public long Channel { get; set; }
        [QuerySqlField(Name = "class")] public long Class { get; set; }
        [QuerySqlField(Name = "classification")] public long Classification { get; set; }
        [QuerySqlField(Name = "company")] public long Company { get; set; }
        [QuerySqlField(Name = "wearertype")] public long Wearertype { get; set; }
        [QuerySqlField(Name = "wearersubtype")] public long Wearersubtype { get; set; }
        [QuerySqlField(Name = "subchannel")] public long Subchannel { get; set; }
        [QuerySqlField(Name = "wearersize")] public long Wearersize { get; set; }
        [QuerySqlField(Name = "wearersegment")] public long Wearersegment { get; set; }
        [QuerySqlField(Name = "outlet")] public long Outlet { get; set; }
        [QuerySqlField(Name = "brandtype")] public long Brandtype { get; set; }
        [QuerySqlField(Name = "outletfamily")] public long Outletfamily { get; set; }
        [QuerySqlField(Name = "retailerregion")] public long Retailerregion { get; set; }
        [QuerySqlField(Name = "wearergender")] public long Wearergender { get; set; }
        [QuerySqlField(Name = "superchannel")] public long Superchannel { get; set; }
        [QuerySqlField(Name = "state")] public long State { get; set; }
        [QuerySqlField(Name = "censusregionusa")] public long Censusregionusa { get; set; }
        [QuerySqlField(Name = "censusdivisionusa")] public long Censusdivisionusa { get; set; }
        [QuerySqlField(Name = "inventory")] public double Inventory { get; set; }
        [QuerySqlField(Name = "unitssold")] public double Unitssold { get; set; }
        [QuerySqlField(Name = "totalvalue")] public double Totalvalue { get; set; }
        [QuerySqlField(Name = "trans")] public double Trans { get; set; }
        [QuerySqlField(Name = "proj_inventory")] public double ProjInventory { get; set; }
        [QuerySqlField(Name = "proj_unitssold")] public double ProjUnitssold { get; set; }
        [QuerySqlField(Name = "proj_totalvalue")] public double ProjTotalvalue { get; set; }
        [QuerySqlField(Name = "totind_stores_totalvalue")] public double TotindStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "stores_totalvalue")] public double StoresTotalvalue { get; set; }
        [QuerySqlField(Name = "store_weight")] public string StoreWeight { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressednc_org")] public long BrandfamilysuppressedncOrg { get; set; }
        [QuerySqlField(Name = "brandtypesuppressed_org")] public long BrandtypesuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressed")] public long Brandfamilysuppressed { get; set; }
        [QuerySqlField(Name = "brandsuppressednc_org")] public long BrandsuppressedncOrg { get; set; }
        [QuerySqlField(Name = "brandsuppressed")] public long Brandsuppressed { get; set; }
        [QuerySqlField(Name = "brandsuppressed_org")] public long BrandsuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandtypesuppressednc_org")] public long BrandtypesuppressedncOrg { get; set; }
        [QuerySqlField(Name = "brandtypesuppressednc")] public long Brandtypesuppressednc { get; set; }
        [QuerySqlField(Name = "proj_stores_totalvalue")] public double ProjStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "totind_proj_stores_totalvalue")] public double TotindProjStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressed_org")] public long BrandfamilysuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandtypesuppressed")] public long Brandtypesuppressed { get; set; }
        [QuerySqlField(Name = "brandsuppressednc")] public long Brandsuppressednc { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressednc")] public long Brandfamilysuppressednc { get; set; }
        [QuerySqlField(Name = "proj_unit_price")] public double ProjUnitPrice { get; set; }
        [QuerySqlField(Name = "store_sublvl_totalvalue")] public double StoreSublvlTotalvalue { get; set; }
        [QuerySqlField(Name = "postal_sublvl_totalvalue")] public double PostalSublvlTotalvalue { get; set; }
        [QuerySqlField(Name = "outletallocation")] public long Outletallocation { get; set; }
        [QuerySqlField(Name = "outletpostalcode")] public string Outletpostalcode { get; set; }
        [QuerySqlField(Name = "actual_units")] public double ActualUnits { get; set; }
        [QuerySqlField(Name = "proj_actual_units")] public double ProjActualUnits { get; set; }
        [QuerySqlField(Name = "numweeks")] public long Numweeks { get; set; }
        [QuerySqlField(Name = "rdollars_adj")] public double RdollarsAdj { get; set; }
        [QuerySqlField(Name = "dollars_adj")] public double DollarsAdj { get; set; }
        [QuerySqlField(Name = "units_adj")] public double UnitsAdj { get; set; }
        [QuerySqlField(Name = "runits_adj")] public double RunitsAdj { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("ppmonth", Ppmonth);
            writer.WriteLong("ppweek", Ppweek);
            writer.WriteLong("distributor", Distributor);
            writer.WriteLong("posoutlet", Posoutlet);
            writer.WriteString("storeid", Storeid);
            writer.WriteString("postalcode", Postalcode);
            writer.WriteString("outletstoreid", Outletstoreid);
            writer.WriteLong("loadid", Loadid);
            writer.WriteLong("dma", Dma);
            writer.WriteLong("year", Year);
            writer.WriteLong("yearhalf", Yearhalf);
            writer.WriteLong("yearqtr", Yearqtr);
            writer.WriteLong("yearmonth", Yearmonth);
            writer.WriteLong("yearweek", Yearweek);
            writer.WriteLong("supercategory", Supercategory);
            writer.WriteLong("subclass", Subclass);
            writer.WriteLong("category", Category);
            writer.WriteLong("categorytype", Categorytype);
            writer.WriteLong("brand", Brand);
            writer.WriteLong("brandfamily", Brandfamily);
            writer.WriteLong("channel", Channel);
            writer.WriteLong("class", Class);
            writer.WriteLong("classification", Classification);
            writer.WriteLong("company", Company);
            writer.WriteLong("wearertype", Wearertype);
            writer.WriteLong("wearersubtype", Wearersubtype);
            writer.WriteLong("subchannel", Subchannel);
            writer.WriteLong("wearersize", Wearersize);
            writer.WriteLong("wearersegment", Wearersegment);
            writer.WriteLong("outlet", Outlet);
            writer.WriteLong("brandtype", Brandtype);
            writer.WriteLong("outletfamily", Outletfamily);
            writer.WriteLong("retailerregion", Retailerregion);
            writer.WriteLong("wearergender", Wearergender);
            writer.WriteLong("superchannel", Superchannel);
            writer.WriteLong("state", State);
            writer.WriteLong("censusregionusa", Censusregionusa);
            writer.WriteLong("censusdivisionusa", Censusdivisionusa);
            writer.WriteDouble("inventory", Inventory);
            writer.WriteDouble("unitssold", Unitssold);
            writer.WriteDouble("totalvalue", Totalvalue);
            writer.WriteDouble("trans", Trans);
            writer.WriteDouble("proj_inventory", ProjInventory);
            writer.WriteDouble("proj_unitssold", ProjUnitssold);
            writer.WriteDouble("proj_totalvalue", ProjTotalvalue);
            writer.WriteDouble("totind_stores_totalvalue", TotindStoresTotalvalue);
            writer.WriteDouble("stores_totalvalue", StoresTotalvalue);
            writer.WriteString("store_weight", StoreWeight);
            writer.WriteLong("brandfamilysuppressednc_org", BrandfamilysuppressedncOrg);
            writer.WriteLong("brandtypesuppressed_org", BrandtypesuppressedOrg);
            writer.WriteLong("brandfamilysuppressed", Brandfamilysuppressed);
            writer.WriteLong("brandsuppressednc_org", BrandsuppressedncOrg);
            writer.WriteLong("brandsuppressed", Brandsuppressed);
            writer.WriteLong("brandsuppressed_org", BrandsuppressedOrg);
            writer.WriteLong("brandtypesuppressednc_org", BrandtypesuppressedncOrg);
            writer.WriteLong("brandtypesuppressednc", Brandtypesuppressednc);
            writer.WriteDouble("proj_stores_totalvalue", ProjStoresTotalvalue);
            writer.WriteDouble("totind_proj_stores_totalvalue", TotindProjStoresTotalvalue);
            writer.WriteLong("brandfamilysuppressed_org", BrandfamilysuppressedOrg);
            writer.WriteLong("brandtypesuppressed", Brandtypesuppressed);
            writer.WriteLong("brandsuppressednc", Brandsuppressednc);
            writer.WriteLong("brandfamilysuppressednc", Brandfamilysuppressednc);
            writer.WriteDouble("proj_unit_price", ProjUnitPrice);
            writer.WriteDouble("store_sublvl_totalvalue", StoreSublvlTotalvalue);
            writer.WriteDouble("postal_sublvl_totalvalue", PostalSublvlTotalvalue);
            writer.WriteLong("outletallocation", Outletallocation);
            writer.WriteString("outletpostalcode", Outletpostalcode);
            writer.WriteDouble("actual_units", ActualUnits);
            writer.WriteDouble("proj_actual_units", ProjActualUnits);
            writer.WriteLong("numweeks", Numweeks);
            writer.WriteDouble("rdollars_adj", RdollarsAdj);
            writer.WriteDouble("dollars_adj", DollarsAdj);
            writer.WriteDouble("units_adj", UnitsAdj);
            writer.WriteDouble("runits_adj", RunitsAdj);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppmonth = reader.ReadLong("ppmonth");
            Ppweek = reader.ReadLong("ppweek");
            Distributor = reader.ReadLong("distributor");
            Posoutlet = reader.ReadLong("posoutlet");
            Storeid = reader.ReadString("storeid");
            Postalcode = reader.ReadString("postalcode");
            Outletstoreid = reader.ReadString("outletstoreid");
            Loadid = reader.ReadLong("loadid");
            Dma = reader.ReadLong("dma");
            Year = reader.ReadLong("year");
            Yearhalf = reader.ReadLong("yearhalf");
            Yearqtr = reader.ReadLong("yearqtr");
            Yearmonth = reader.ReadLong("yearmonth");
            Yearweek = reader.ReadLong("yearweek");
            Supercategory = reader.ReadLong("supercategory");
            Subclass = reader.ReadLong("subclass");
            Category = reader.ReadLong("category");
            Categorytype = reader.ReadLong("categorytype");
            Brand = reader.ReadLong("brand");
            Brandfamily = reader.ReadLong("brandfamily");
            Channel = reader.ReadLong("channel");
            Class = reader.ReadLong("class");
            Classification = reader.ReadLong("classification");
            Company = reader.ReadLong("company");
            Wearertype = reader.ReadLong("wearertype");
            Wearersubtype = reader.ReadLong("wearersubtype");
            Subchannel = reader.ReadLong("subchannel");
            Wearersize = reader.ReadLong("wearersize");
            Wearersegment = reader.ReadLong("wearersegment");
            Outlet = reader.ReadLong("outlet");
            Brandtype = reader.ReadLong("brandtype");
            Outletfamily = reader.ReadLong("outletfamily");
            Retailerregion = reader.ReadLong("retailerregion");
            Wearergender = reader.ReadLong("wearergender");
            Superchannel = reader.ReadLong("superchannel");
            State = reader.ReadLong("state");
            Censusregionusa = reader.ReadLong("censusregionusa");
            Censusdivisionusa = reader.ReadLong("censusdivisionusa");
            Inventory = reader.ReadDouble("inventory");
            Unitssold = reader.ReadDouble("unitssold");
            Totalvalue = reader.ReadDouble("totalvalue");
            Trans = reader.ReadDouble("trans");
            ProjInventory = reader.ReadDouble("proj_inventory");
            ProjUnitssold = reader.ReadDouble("proj_unitssold");
            ProjTotalvalue = reader.ReadDouble("proj_totalvalue");
            TotindStoresTotalvalue = reader.ReadDouble("totind_stores_totalvalue");
            StoresTotalvalue = reader.ReadDouble("stores_totalvalue");
            StoreWeight = reader.ReadString("store_weight");
            BrandfamilysuppressedncOrg = reader.ReadLong("brandfamilysuppressednc_org");
            BrandtypesuppressedOrg = reader.ReadLong("brandtypesuppressed_org");
            Brandfamilysuppressed = reader.ReadLong("brandfamilysuppressed");
            BrandsuppressedncOrg = reader.ReadLong("brandsuppressednc_org");
            Brandsuppressed = reader.ReadLong("brandsuppressed");
            BrandsuppressedOrg = reader.ReadLong("brandsuppressed_org");
            BrandtypesuppressedncOrg = reader.ReadLong("brandtypesuppressednc_org");
            Brandtypesuppressednc = reader.ReadLong("brandtypesuppressednc");
            ProjStoresTotalvalue = reader.ReadDouble("proj_stores_totalvalue");
            TotindProjStoresTotalvalue = reader.ReadDouble("totind_proj_stores_totalvalue");
            BrandfamilysuppressedOrg = reader.ReadLong("brandfamilysuppressed_org");
            Brandtypesuppressed = reader.ReadLong("brandtypesuppressed");
            Brandsuppressednc = reader.ReadLong("brandsuppressednc");
            Brandfamilysuppressednc = reader.ReadLong("brandfamilysuppressednc");
            ProjUnitPrice = reader.ReadDouble("proj_unit_price");
            StoreSublvlTotalvalue = reader.ReadDouble("store_sublvl_totalvalue");
            PostalSublvlTotalvalue = reader.ReadDouble("postal_sublvl_totalvalue");
            Outletallocation = reader.ReadLong("outletallocation");
            Outletpostalcode = reader.ReadString("outletpostalcode");
            ActualUnits = reader.ReadDouble("actual_units");
            ProjActualUnits = reader.ReadDouble("proj_actual_units");
            Numweeks = reader.ReadLong("numweeks");
            RdollarsAdj = reader.ReadDouble("rdollars_adj");
            DollarsAdj = reader.ReadDouble("dollars_adj");
            UnitsAdj = reader.ReadDouble("units_adj");
            RunitsAdj = reader.ReadDouble("runits_adj");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Ppmonth = *(long*) (p + 0);
                Ppweek = *(long*) (p + 8);
                Distributor = *(long*) (p + 16);
                Posoutlet = *(long*) (p + 24);
                Storeid = Encoding.ASCII.GetString(buffer, 32, 64).TrimEnd();
                Postalcode = Encoding.ASCII.GetString(buffer, 96, 64).TrimEnd();
                Outletstoreid = Encoding.ASCII.GetString(buffer, 160, 64).TrimEnd();
                Loadid = *(long*) (p + 224);
                Dma = *(long*) (p + 232);
                Year = *(long*) (p + 240);
                Yearhalf = *(long*) (p + 248);
                Yearqtr = *(long*) (p + 256);
                Yearmonth = *(long*) (p + 264);
                Yearweek = *(long*) (p + 272);
                Supercategory = *(long*) (p + 280);
                Subclass = *(long*) (p + 288);
                Category = *(long*) (p + 296);
                Categorytype = *(long*) (p + 304);
                Brand = *(long*) (p + 312);
                Brandfamily = *(long*) (p + 320);
                Channel = *(long*) (p + 328);
                Class = *(long*) (p + 336);
                Classification = *(long*) (p + 344);
                Company = *(long*) (p + 352);
                Wearertype = *(long*) (p + 360);
                Wearersubtype = *(long*) (p + 368);
                Subchannel = *(long*) (p + 376);
                Wearersize = *(long*) (p + 384);
                Wearersegment = *(long*) (p + 392);
                Outlet = *(long*) (p + 400);
                Brandtype = *(long*) (p + 408);
                Outletfamily = *(long*) (p + 416);
                Retailerregion = *(long*) (p + 424);
                Wearergender = *(long*) (p + 432);
                Superchannel = *(long*) (p + 440);
                State = *(long*) (p + 448);
                Censusregionusa = *(long*) (p + 456);
                Censusdivisionusa = *(long*) (p + 464);
                Inventory = *(double*) (p + 472);
                Unitssold = *(double*) (p + 480);
                Totalvalue = *(double*) (p + 488);
                Trans = *(double*) (p + 496);
                ProjInventory = *(double*) (p + 504);
                ProjUnitssold = *(double*) (p + 512);
                ProjTotalvalue = *(double*) (p + 520);
                TotindStoresTotalvalue = *(double*) (p + 528);
                StoresTotalvalue = *(double*) (p + 536);
                StoreWeight = Encoding.ASCII.GetString(buffer, 544, 64).TrimEnd();
                BrandfamilysuppressedncOrg = *(long*) (p + 608);
                BrandtypesuppressedOrg = *(long*) (p + 616);
                Brandfamilysuppressed = *(long*) (p + 624);
                BrandsuppressedncOrg = *(long*) (p + 632);
                Brandsuppressed = *(long*) (p + 640);
                BrandsuppressedOrg = *(long*) (p + 648);
                BrandtypesuppressedncOrg = *(long*) (p + 656);
                Brandtypesuppressednc = *(long*) (p + 664);
                ProjStoresTotalvalue = *(double*) (p + 672);
                TotindProjStoresTotalvalue = *(double*) (p + 680);
                BrandfamilysuppressedOrg = *(long*) (p + 688);
                Brandtypesuppressed = *(long*) (p + 696);
                Brandsuppressednc = *(long*) (p + 704);
                Brandfamilysuppressednc = *(long*) (p + 712);
                ProjUnitPrice = *(double*) (p + 720);
                StoreSublvlTotalvalue = *(double*) (p + 728);
                PostalSublvlTotalvalue = *(double*) (p + 736);
                Outletallocation = *(long*) (p + 744);
                Outletpostalcode = Encoding.ASCII.GetString(buffer, 752, 64).TrimEnd();
                ActualUnits = *(double*) (p + 816);
                ProjActualUnits = *(double*) (p + 824);
                Numweeks = *(long*) (p + 832);
                RdollarsAdj = *(double*) (p + 840);
                DollarsAdj = *(double*) (p + 848);
                UnitsAdj = *(double*) (p + 856);
                RunitsAdj = *(double*) (p + 864);
            }
        }
    }
}
