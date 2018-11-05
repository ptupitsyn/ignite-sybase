// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class FactDataItem : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "ppweek")] public long Ppweek { get; set; }
        [QuerySqlField(Name = "ppmonth")] public long Ppmonth { get; set; }
        [QuerySqlField(Name = "country")] public long Country { get; set; }
        [QuerySqlField(Name = "itemid")] public long Itemid { get; set; }
        [QuerySqlField(Name = "loadid")] public long Loadid { get; set; }
        [QuerySqlField(Name = "pos_id")] public long PosId { get; set; }
        [QuerySqlField(Name = "rid")] public long Rid { get; set; }
        [QuerySqlField(Name = "posoutlet")] public long Posoutlet { get; set; }
        [QuerySqlField(Name = "storeid")] public string Storeid { get; set; }
        [QuerySqlField(Name = "postalcode")] public string Postalcode { get; set; }
        [QuerySqlField(Name = "outletstoreid")] public string Outletstoreid { get; set; }
        [QuerySqlField(Name = "retailer_item_id")] public long RetailerItemId { get; set; }
        [QuerySqlField(Name = "sku")] public string Sku { get; set; }
        [QuerySqlField(Name = "itemnumber")] public long Itemnumber { get; set; }
        [QuerySqlField(Name = "wearertype")] public long Wearertype { get; set; }
        [QuerySqlField(Name = "wearersubtype")] public long Wearersubtype { get; set; }
        [QuerySqlField(Name = "wearersize")] public long Wearersize { get; set; }
        [QuerySqlField(Name = "retailerregion")] public long Retailerregion { get; set; }
        [QuerySqlField(Name = "wearersegment")] public long Wearersegment { get; set; }
        [QuerySqlField(Name = "wearergender")] public long Wearergender { get; set; }
        [QuerySqlField(Name = "superchannel")] public long Superchannel { get; set; }
        [QuerySqlField(Name = "supercategory")] public long Supercategory { get; set; }
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "outletfamily")] public long Outletfamily { get; set; }
        [QuerySqlField(Name = "outlet")] public long Outlet { get; set; }
        [QuerySqlField(Name = "subchannel")] public long Subchannel { get; set; }
        [QuerySqlField(Name = "company")] public long Company { get; set; }
        [QuerySqlField(Name = "classification")] public long Classification { get; set; }
        [QuerySqlField(Name = "class")] public long Class { get; set; }
        [QuerySqlField(Name = "channel")] public long Channel { get; set; }
        [QuerySqlField(Name = "categorytype")] public long Categorytype { get; set; }
        [QuerySqlField(Name = "category")] public long Category { get; set; }
        [QuerySqlField(Name = "brandtype")] public long Brandtype { get; set; }
        [QuerySqlField(Name = "brandfamily")] public long Brandfamily { get; set; }
        [QuerySqlField(Name = "brand")] public long Brand { get; set; }
        [QuerySqlField(Name = "itemnumbersuppressed")] public long Itemnumbersuppressed { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressed")] public long Brandfamilysuppressed { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressed_org")] public long BrandfamilysuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressednc")] public long Brandfamilysuppressednc { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressednc_org")] public long BrandfamilysuppressedncOrg { get; set; }
        [QuerySqlField(Name = "brandsuppressed")] public long Brandsuppressed { get; set; }
        [QuerySqlField(Name = "brandsuppressed_org")] public long BrandsuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandsuppressednc")] public long Brandsuppressednc { get; set; }
        [QuerySqlField(Name = "brandsuppressednc_org")] public long BrandsuppressedncOrg { get; set; }
        [QuerySqlField(Name = "itemnumbersuppressed_org")] public long ItemnumbersuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandtypesuppressed")] public long Brandtypesuppressed { get; set; }
        [QuerySqlField(Name = "brandtypesuppressed_org")] public long BrandtypesuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandtypesuppressednc")] public long Brandtypesuppressednc { get; set; }
        [QuerySqlField(Name = "brandtypesuppressednc_org")] public long BrandtypesuppressedncOrg { get; set; }
        [QuerySqlField(Name = "itemnumbersuppressednc")] public long Itemnumbersuppressednc { get; set; }
        [QuerySqlField(Name = "itemnumbersuppressednc_org")] public long ItemnumbersuppressedncOrg { get; set; }
        [QuerySqlField(Name = "introdate")] public long Introdate { get; set; }
        [QuerySqlField(Name = "censusregionusa")] public long Censusregionusa { get; set; }
        [QuerySqlField(Name = "censusdivisionusa")] public long Censusdivisionusa { get; set; }
        [QuerySqlField(Name = "state")] public long State { get; set; }
        [QuerySqlField(Name = "dma")] public long Dma { get; set; }
        [QuerySqlField(Name = "cbsa")] public long Cbsa { get; set; }
        [QuerySqlField(Name = "distributor")] public long Distributor { get; set; }
        [QuerySqlField(Name = "year")] public long Year { get; set; }
        [QuerySqlField(Name = "yearhalf")] public long Yearhalf { get; set; }
        [QuerySqlField(Name = "yearqtr")] public long Yearqtr { get; set; }
        [QuerySqlField(Name = "yearmonth")] public long Yearmonth { get; set; }
        [QuerySqlField(Name = "yearweek")] public long Yearweek { get; set; }
        [QuerySqlField(Name = "raw_inventory")] public double RawInventory { get; set; }
        [QuerySqlField(Name = "raw_unitssold")] public double RawUnitssold { get; set; }
        [QuerySqlField(Name = "raw_totalvalue")] public double RawTotalvalue { get; set; }
        [QuerySqlField(Name = "inventory")] public double Inventory { get; set; }
        [QuerySqlField(Name = "unitssold")] public double Unitssold { get; set; }
        [QuerySqlField(Name = "totalvalue")] public double Totalvalue { get; set; }
        [QuerySqlField(Name = "trans")] public double Trans { get; set; }
        [QuerySqlField(Name = "proj_inventory")] public double ProjInventory { get; set; }
        [QuerySqlField(Name = "proj_unitssold")] public double ProjUnitssold { get; set; }
        [QuerySqlField(Name = "proj_totalvalue")] public double ProjTotalvalue { get; set; }
        [QuerySqlField(Name = "stores_totalvalue")] public double StoresTotalvalue { get; set; }
        [QuerySqlField(Name = "totind_stores_totalvalue")] public double TotindStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "totind_proj_stores_totalvalue")] public double TotindProjStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "proj_stores_totalvalue")] public double ProjStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "units_per_package")] public double UnitsPerPackage { get; set; }
        [QuerySqlField(Name = "stores_totalvalue_factor")] public double StoresTotalvalueFactor { get; set; }
        [QuerySqlField(Name = "unit_price")] public double UnitPrice { get; set; }
        [QuerySqlField(Name = "proj_unit_price")] public double ProjUnitPrice { get; set; }
        [QuerySqlField(Name = "upc_code")] public string UpcCode { get; set; }
        [QuerySqlField(Name = "upc_type")] public string UpcType { get; set; }
        [QuerySqlField(Name = "store_sublvl_totalvalue")] public double StoreSublvlTotalvalue { get; set; }
        [QuerySqlField(Name = "postal_sublvl_totalvalue")] public double PostalSublvlTotalvalue { get; set; }
        [QuerySqlField(Name = "outletpostalcode")] public string Outletpostalcode { get; set; }
        [QuerySqlField(Name = "skusuppressed")] public string Skusuppressed { get; set; }
        [QuerySqlField(Name = "itemidsuppressed")] public string Itemidsuppressed { get; set; }
        [QuerySqlField(Name = "retailer_item_idsuppressed")] public long RetailerItemIdsuppressed { get; set; }
        [QuerySqlField(Name = "retailer_item_idsuppressednc")] public long RetailerItemIdsuppressednc { get; set; }
        [QuerySqlField(Name = "itemidsuppressednc")] public string Itemidsuppressednc { get; set; }
        [QuerySqlField(Name = "skusuppressednc")] public string Skusuppressednc { get; set; }
        [QuerySqlField(Name = "upc_codesuppressednc")] public string UpcCodesuppressednc { get; set; }
        [QuerySqlField(Name = "upc_codesuppressed")] public string UpcCodesuppressed { get; set; }
        [QuerySqlField(Name = "ractunts_adj")] public double RactuntsAdj { get; set; }
        [QuerySqlField(Name = "runits_adj")] public double RunitsAdj { get; set; }
        [QuerySqlField(Name = "units_adj")] public double UnitsAdj { get; set; }
        [QuerySqlField(Name = "rdollars_adj")] public double RdollarsAdj { get; set; }
        [QuerySqlField(Name = "dollars_adj")] public double DollarsAdj { get; set; }
        [QuerySqlField(Name = "outletallocation")] public long Outletallocation { get; set; }
        [QuerySqlField(Name = "actunts_adj")] public double ActuntsAdj { get; set; }
        [QuerySqlField(Name = "actual_units")] public double ActualUnits { get; set; }
        [QuerySqlField(Name = "proj_actual_units")] public double ProjActualUnits { get; set; }
        [QuerySqlField(Name = "numweeks")] public long Numweeks { get; set; }
        [QuerySqlField(Name = "store_weight")] public string StoreWeight { get; set; }
        [QuerySqlField(Name = "avg_unit_price")] public double AvgUnitPrice { get; set; }
        [QuerySqlField(Name = "avg_prj_unit_price")] public double AvgPrjUnitPrice { get; set; }
        [QuerySqlField(Name = "avg_act_unit_price")] public double AvgActUnitPrice { get; set; }
        [QuerySqlField(Name = "avg_prj_act_unit_price")] public double AvgPrjActUnitPrice { get; set; }
        [QuerySqlField(Name = "allbrandcompanysuppressed")] public long Allbrandcompanysuppressed { get; set; }
        [QuerySqlField(Name = "allbrandsuppressed")] public long Allbrandsuppressed { get; set; }
        [QuerySqlField(Name = "allbrandfamilysuppressed")] public long Allbrandfamilysuppressed { get; set; }
        [QuerySqlField(Name = "allbrandderivedsuppressed")] public long Allbrandderivedsuppressed { get; set; }
        [QuerySqlField(Name = "allbrandcompany")] public long Allbrandcompany { get; set; }
        [QuerySqlField(Name = "allbrandderived")] public long Allbrandderived { get; set; }
        [QuerySqlField(Name = "alloutlet")] public long Alloutlet { get; set; }
        [QuerySqlField(Name = "altbusiness")] public long Altbusiness { get; set; }
        [QuerySqlField(Name = "alloutletfamily")] public long Alloutletfamily { get; set; }
        [QuerySqlField(Name = "retsupercategoryderived")] public long Retsupercategoryderived { get; set; }
        [QuerySqlField(Name = "retsubcategoryderived")] public long Retsubcategoryderived { get; set; }
        [QuerySqlField(Name = "rethidsubcategoryderived")] public long Rethidsubcategoryderived { get; set; }
        [QuerySqlField(Name = "wearerderived")] public long Wearerderived { get; set; }
        [QuerySqlField(Name = "allindustry")] public long Allindustry { get; set; }
        [QuerySqlField(Name = "wearergenderderived")] public long Wearergenderderived { get; set; }
        [QuerySqlField(Name = "allcategoryderived")] public long Allcategoryderived { get; set; }
        [QuerySqlField(Name = "allsector")] public long Allsector { get; set; }
        [QuerySqlField(Name = "alloutletderived")] public long Alloutletderived { get; set; }
        [QuerySqlField(Name = "allbrandfamily")] public long Allbrandfamily { get; set; }
        [QuerySqlField(Name = "allbrand")] public long Allbrand { get; set; }
        [QuerySqlField(Name = "retcategoryderived")] public long Retcategoryderived { get; set; }
        [QuerySqlField(Name = "allsubcategoryderived")] public long Allsubcategoryderived { get; set; }
        [QuerySqlField(Name = "retcategorygroupderived")] public long Retcategorygroupderived { get; set; }
        [QuerySqlField(Name = "bbysubclass")] public long Bbysubclass { get; set; }
        [QuerySqlField(Name = "bbymerchantlevel")] public long Bbymerchantlevel { get; set; }
        [QuerySqlField(Name = "bbyvplevel")] public long Bbyvplevel { get; set; }
        [QuerySqlField(Name = "bbydepartment")] public long Bbydepartment { get; set; }
        [QuerySqlField(Name = "bbyclass")] public long Bbyclass { get; set; }
        [QuerySqlField(Name = "bbybusinessgroup")] public long Bbybusinessgroup { get; set; }
        [QuerySqlField(Name = "avg_prj_act_unit_price_outlet")] public double AvgPrjActUnitPriceOutlet { get; set; }
        [QuerySqlField(Name = "avg_act_unit_price_channel")] public double AvgActUnitPriceChannel { get; set; }
        [QuerySqlField(Name = "avg_prj_act_unit_price_channel")] public double AvgPrjActUnitPriceChannel { get; set; }
        [QuerySqlField(Name = "avg_unit_price_outlet")] public double AvgUnitPriceOutlet { get; set; }
        [QuerySqlField(Name = "avg_prj_unit_price_channel")] public double AvgPrjUnitPriceChannel { get; set; }
        [QuerySqlField(Name = "avg_unit_price_channel")] public double AvgUnitPriceChannel { get; set; }
        [QuerySqlField(Name = "avg_act_unit_price_outlet")] public double AvgActUnitPriceOutlet { get; set; }
        [QuerySqlField(Name = "avg_prj_unit_price_outlet")] public double AvgPrjUnitPriceOutlet { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("ppweek", Ppweek);
            writer.WriteLong("ppmonth", Ppmonth);
            writer.WriteLong("country", Country);
            writer.WriteLong("itemid", Itemid);
            writer.WriteLong("loadid", Loadid);
            writer.WriteLong("pos_id", PosId);
            writer.WriteLong("rid", Rid);
            writer.WriteLong("posoutlet", Posoutlet);
            writer.WriteString("storeid", Storeid);
            writer.WriteString("postalcode", Postalcode);
            writer.WriteString("outletstoreid", Outletstoreid);
            writer.WriteLong("retailer_item_id", RetailerItemId);
            writer.WriteString("sku", Sku);
            writer.WriteLong("itemnumber", Itemnumber);
            writer.WriteLong("wearertype", Wearertype);
            writer.WriteLong("wearersubtype", Wearersubtype);
            writer.WriteLong("wearersize", Wearersize);
            writer.WriteLong("retailerregion", Retailerregion);
            writer.WriteLong("wearersegment", Wearersegment);
            writer.WriteLong("wearergender", Wearergender);
            writer.WriteLong("superchannel", Superchannel);
            writer.WriteLong("supercategory", Supercategory);
            writer.WriteLong("subclass", Subclass);
            writer.WriteLong("outletfamily", Outletfamily);
            writer.WriteLong("outlet", Outlet);
            writer.WriteLong("subchannel", Subchannel);
            writer.WriteLong("company", Company);
            writer.WriteLong("classification", Classification);
            writer.WriteLong("class", Class);
            writer.WriteLong("channel", Channel);
            writer.WriteLong("categorytype", Categorytype);
            writer.WriteLong("category", Category);
            writer.WriteLong("brandtype", Brandtype);
            writer.WriteLong("brandfamily", Brandfamily);
            writer.WriteLong("brand", Brand);
            writer.WriteLong("itemnumbersuppressed", Itemnumbersuppressed);
            writer.WriteLong("brandfamilysuppressed", Brandfamilysuppressed);
            writer.WriteLong("brandfamilysuppressed_org", BrandfamilysuppressedOrg);
            writer.WriteLong("brandfamilysuppressednc", Brandfamilysuppressednc);
            writer.WriteLong("brandfamilysuppressednc_org", BrandfamilysuppressedncOrg);
            writer.WriteLong("brandsuppressed", Brandsuppressed);
            writer.WriteLong("brandsuppressed_org", BrandsuppressedOrg);
            writer.WriteLong("brandsuppressednc", Brandsuppressednc);
            writer.WriteLong("brandsuppressednc_org", BrandsuppressedncOrg);
            writer.WriteLong("itemnumbersuppressed_org", ItemnumbersuppressedOrg);
            writer.WriteLong("brandtypesuppressed", Brandtypesuppressed);
            writer.WriteLong("brandtypesuppressed_org", BrandtypesuppressedOrg);
            writer.WriteLong("brandtypesuppressednc", Brandtypesuppressednc);
            writer.WriteLong("brandtypesuppressednc_org", BrandtypesuppressedncOrg);
            writer.WriteLong("itemnumbersuppressednc", Itemnumbersuppressednc);
            writer.WriteLong("itemnumbersuppressednc_org", ItemnumbersuppressedncOrg);
            writer.WriteLong("introdate", Introdate);
            writer.WriteLong("censusregionusa", Censusregionusa);
            writer.WriteLong("censusdivisionusa", Censusdivisionusa);
            writer.WriteLong("state", State);
            writer.WriteLong("dma", Dma);
            writer.WriteLong("cbsa", Cbsa);
            writer.WriteLong("distributor", Distributor);
            writer.WriteLong("year", Year);
            writer.WriteLong("yearhalf", Yearhalf);
            writer.WriteLong("yearqtr", Yearqtr);
            writer.WriteLong("yearmonth", Yearmonth);
            writer.WriteLong("yearweek", Yearweek);
            writer.WriteDouble("raw_inventory", RawInventory);
            writer.WriteDouble("raw_unitssold", RawUnitssold);
            writer.WriteDouble("raw_totalvalue", RawTotalvalue);
            writer.WriteDouble("inventory", Inventory);
            writer.WriteDouble("unitssold", Unitssold);
            writer.WriteDouble("totalvalue", Totalvalue);
            writer.WriteDouble("trans", Trans);
            writer.WriteDouble("proj_inventory", ProjInventory);
            writer.WriteDouble("proj_unitssold", ProjUnitssold);
            writer.WriteDouble("proj_totalvalue", ProjTotalvalue);
            writer.WriteDouble("stores_totalvalue", StoresTotalvalue);
            writer.WriteDouble("totind_stores_totalvalue", TotindStoresTotalvalue);
            writer.WriteDouble("totind_proj_stores_totalvalue", TotindProjStoresTotalvalue);
            writer.WriteDouble("proj_stores_totalvalue", ProjStoresTotalvalue);
            writer.WriteDouble("units_per_package", UnitsPerPackage);
            writer.WriteDouble("stores_totalvalue_factor", StoresTotalvalueFactor);
            writer.WriteDouble("unit_price", UnitPrice);
            writer.WriteDouble("proj_unit_price", ProjUnitPrice);
            writer.WriteString("upc_code", UpcCode);
            writer.WriteString("upc_type", UpcType);
            writer.WriteDouble("store_sublvl_totalvalue", StoreSublvlTotalvalue);
            writer.WriteDouble("postal_sublvl_totalvalue", PostalSublvlTotalvalue);
            writer.WriteString("outletpostalcode", Outletpostalcode);
            writer.WriteString("skusuppressed", Skusuppressed);
            writer.WriteString("itemidsuppressed", Itemidsuppressed);
            writer.WriteLong("retailer_item_idsuppressed", RetailerItemIdsuppressed);
            writer.WriteLong("retailer_item_idsuppressednc", RetailerItemIdsuppressednc);
            writer.WriteString("itemidsuppressednc", Itemidsuppressednc);
            writer.WriteString("skusuppressednc", Skusuppressednc);
            writer.WriteString("upc_codesuppressednc", UpcCodesuppressednc);
            writer.WriteString("upc_codesuppressed", UpcCodesuppressed);
            writer.WriteDouble("ractunts_adj", RactuntsAdj);
            writer.WriteDouble("runits_adj", RunitsAdj);
            writer.WriteDouble("units_adj", UnitsAdj);
            writer.WriteDouble("rdollars_adj", RdollarsAdj);
            writer.WriteDouble("dollars_adj", DollarsAdj);
            writer.WriteLong("outletallocation", Outletallocation);
            writer.WriteDouble("actunts_adj", ActuntsAdj);
            writer.WriteDouble("actual_units", ActualUnits);
            writer.WriteDouble("proj_actual_units", ProjActualUnits);
            writer.WriteLong("numweeks", Numweeks);
            writer.WriteString("store_weight", StoreWeight);
            writer.WriteDouble("avg_unit_price", AvgUnitPrice);
            writer.WriteDouble("avg_prj_unit_price", AvgPrjUnitPrice);
            writer.WriteDouble("avg_act_unit_price", AvgActUnitPrice);
            writer.WriteDouble("avg_prj_act_unit_price", AvgPrjActUnitPrice);
            writer.WriteLong("allbrandcompanysuppressed", Allbrandcompanysuppressed);
            writer.WriteLong("allbrandsuppressed", Allbrandsuppressed);
            writer.WriteLong("allbrandfamilysuppressed", Allbrandfamilysuppressed);
            writer.WriteLong("allbrandderivedsuppressed", Allbrandderivedsuppressed);
            writer.WriteLong("allbrandcompany", Allbrandcompany);
            writer.WriteLong("allbrandderived", Allbrandderived);
            writer.WriteLong("alloutlet", Alloutlet);
            writer.WriteLong("altbusiness", Altbusiness);
            writer.WriteLong("alloutletfamily", Alloutletfamily);
            writer.WriteLong("retsupercategoryderived", Retsupercategoryderived);
            writer.WriteLong("retsubcategoryderived", Retsubcategoryderived);
            writer.WriteLong("rethidsubcategoryderived", Rethidsubcategoryderived);
            writer.WriteLong("wearerderived", Wearerderived);
            writer.WriteLong("allindustry", Allindustry);
            writer.WriteLong("wearergenderderived", Wearergenderderived);
            writer.WriteLong("allcategoryderived", Allcategoryderived);
            writer.WriteLong("allsector", Allsector);
            writer.WriteLong("alloutletderived", Alloutletderived);
            writer.WriteLong("allbrandfamily", Allbrandfamily);
            writer.WriteLong("allbrand", Allbrand);
            writer.WriteLong("retcategoryderived", Retcategoryderived);
            writer.WriteLong("allsubcategoryderived", Allsubcategoryderived);
            writer.WriteLong("retcategorygroupderived", Retcategorygroupderived);
            writer.WriteLong("bbysubclass", Bbysubclass);
            writer.WriteLong("bbymerchantlevel", Bbymerchantlevel);
            writer.WriteLong("bbyvplevel", Bbyvplevel);
            writer.WriteLong("bbydepartment", Bbydepartment);
            writer.WriteLong("bbyclass", Bbyclass);
            writer.WriteLong("bbybusinessgroup", Bbybusinessgroup);
            writer.WriteDouble("avg_prj_act_unit_price_outlet", AvgPrjActUnitPriceOutlet);
            writer.WriteDouble("avg_act_unit_price_channel", AvgActUnitPriceChannel);
            writer.WriteDouble("avg_prj_act_unit_price_channel", AvgPrjActUnitPriceChannel);
            writer.WriteDouble("avg_unit_price_outlet", AvgUnitPriceOutlet);
            writer.WriteDouble("avg_prj_unit_price_channel", AvgPrjUnitPriceChannel);
            writer.WriteDouble("avg_unit_price_channel", AvgUnitPriceChannel);
            writer.WriteDouble("avg_act_unit_price_outlet", AvgActUnitPriceOutlet);
            writer.WriteDouble("avg_prj_unit_price_outlet", AvgPrjUnitPriceOutlet);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppweek = reader.ReadLong("ppweek");
            Ppmonth = reader.ReadLong("ppmonth");
            Country = reader.ReadLong("country");
            Itemid = reader.ReadLong("itemid");
            Loadid = reader.ReadLong("loadid");
            PosId = reader.ReadLong("pos_id");
            Rid = reader.ReadLong("rid");
            Posoutlet = reader.ReadLong("posoutlet");
            Storeid = reader.ReadString("storeid");
            Postalcode = reader.ReadString("postalcode");
            Outletstoreid = reader.ReadString("outletstoreid");
            RetailerItemId = reader.ReadLong("retailer_item_id");
            Sku = reader.ReadString("sku");
            Itemnumber = reader.ReadLong("itemnumber");
            Wearertype = reader.ReadLong("wearertype");
            Wearersubtype = reader.ReadLong("wearersubtype");
            Wearersize = reader.ReadLong("wearersize");
            Retailerregion = reader.ReadLong("retailerregion");
            Wearersegment = reader.ReadLong("wearersegment");
            Wearergender = reader.ReadLong("wearergender");
            Superchannel = reader.ReadLong("superchannel");
            Supercategory = reader.ReadLong("supercategory");
            Subclass = reader.ReadLong("subclass");
            Outletfamily = reader.ReadLong("outletfamily");
            Outlet = reader.ReadLong("outlet");
            Subchannel = reader.ReadLong("subchannel");
            Company = reader.ReadLong("company");
            Classification = reader.ReadLong("classification");
            Class = reader.ReadLong("class");
            Channel = reader.ReadLong("channel");
            Categorytype = reader.ReadLong("categorytype");
            Category = reader.ReadLong("category");
            Brandtype = reader.ReadLong("brandtype");
            Brandfamily = reader.ReadLong("brandfamily");
            Brand = reader.ReadLong("brand");
            Itemnumbersuppressed = reader.ReadLong("itemnumbersuppressed");
            Brandfamilysuppressed = reader.ReadLong("brandfamilysuppressed");
            BrandfamilysuppressedOrg = reader.ReadLong("brandfamilysuppressed_org");
            Brandfamilysuppressednc = reader.ReadLong("brandfamilysuppressednc");
            BrandfamilysuppressedncOrg = reader.ReadLong("brandfamilysuppressednc_org");
            Brandsuppressed = reader.ReadLong("brandsuppressed");
            BrandsuppressedOrg = reader.ReadLong("brandsuppressed_org");
            Brandsuppressednc = reader.ReadLong("brandsuppressednc");
            BrandsuppressedncOrg = reader.ReadLong("brandsuppressednc_org");
            ItemnumbersuppressedOrg = reader.ReadLong("itemnumbersuppressed_org");
            Brandtypesuppressed = reader.ReadLong("brandtypesuppressed");
            BrandtypesuppressedOrg = reader.ReadLong("brandtypesuppressed_org");
            Brandtypesuppressednc = reader.ReadLong("brandtypesuppressednc");
            BrandtypesuppressedncOrg = reader.ReadLong("brandtypesuppressednc_org");
            Itemnumbersuppressednc = reader.ReadLong("itemnumbersuppressednc");
            ItemnumbersuppressedncOrg = reader.ReadLong("itemnumbersuppressednc_org");
            Introdate = reader.ReadLong("introdate");
            Censusregionusa = reader.ReadLong("censusregionusa");
            Censusdivisionusa = reader.ReadLong("censusdivisionusa");
            State = reader.ReadLong("state");
            Dma = reader.ReadLong("dma");
            Cbsa = reader.ReadLong("cbsa");
            Distributor = reader.ReadLong("distributor");
            Year = reader.ReadLong("year");
            Yearhalf = reader.ReadLong("yearhalf");
            Yearqtr = reader.ReadLong("yearqtr");
            Yearmonth = reader.ReadLong("yearmonth");
            Yearweek = reader.ReadLong("yearweek");
            RawInventory = reader.ReadDouble("raw_inventory");
            RawUnitssold = reader.ReadDouble("raw_unitssold");
            RawTotalvalue = reader.ReadDouble("raw_totalvalue");
            Inventory = reader.ReadDouble("inventory");
            Unitssold = reader.ReadDouble("unitssold");
            Totalvalue = reader.ReadDouble("totalvalue");
            Trans = reader.ReadDouble("trans");
            ProjInventory = reader.ReadDouble("proj_inventory");
            ProjUnitssold = reader.ReadDouble("proj_unitssold");
            ProjTotalvalue = reader.ReadDouble("proj_totalvalue");
            StoresTotalvalue = reader.ReadDouble("stores_totalvalue");
            TotindStoresTotalvalue = reader.ReadDouble("totind_stores_totalvalue");
            TotindProjStoresTotalvalue = reader.ReadDouble("totind_proj_stores_totalvalue");
            ProjStoresTotalvalue = reader.ReadDouble("proj_stores_totalvalue");
            UnitsPerPackage = reader.ReadDouble("units_per_package");
            StoresTotalvalueFactor = reader.ReadDouble("stores_totalvalue_factor");
            UnitPrice = reader.ReadDouble("unit_price");
            ProjUnitPrice = reader.ReadDouble("proj_unit_price");
            UpcCode = reader.ReadString("upc_code");
            UpcType = reader.ReadString("upc_type");
            StoreSublvlTotalvalue = reader.ReadDouble("store_sublvl_totalvalue");
            PostalSublvlTotalvalue = reader.ReadDouble("postal_sublvl_totalvalue");
            Outletpostalcode = reader.ReadString("outletpostalcode");
            Skusuppressed = reader.ReadString("skusuppressed");
            Itemidsuppressed = reader.ReadString("itemidsuppressed");
            RetailerItemIdsuppressed = reader.ReadLong("retailer_item_idsuppressed");
            RetailerItemIdsuppressednc = reader.ReadLong("retailer_item_idsuppressednc");
            Itemidsuppressednc = reader.ReadString("itemidsuppressednc");
            Skusuppressednc = reader.ReadString("skusuppressednc");
            UpcCodesuppressednc = reader.ReadString("upc_codesuppressednc");
            UpcCodesuppressed = reader.ReadString("upc_codesuppressed");
            RactuntsAdj = reader.ReadDouble("ractunts_adj");
            RunitsAdj = reader.ReadDouble("runits_adj");
            UnitsAdj = reader.ReadDouble("units_adj");
            RdollarsAdj = reader.ReadDouble("rdollars_adj");
            DollarsAdj = reader.ReadDouble("dollars_adj");
            Outletallocation = reader.ReadLong("outletallocation");
            ActuntsAdj = reader.ReadDouble("actunts_adj");
            ActualUnits = reader.ReadDouble("actual_units");
            ProjActualUnits = reader.ReadDouble("proj_actual_units");
            Numweeks = reader.ReadLong("numweeks");
            StoreWeight = reader.ReadString("store_weight");
            AvgUnitPrice = reader.ReadDouble("avg_unit_price");
            AvgPrjUnitPrice = reader.ReadDouble("avg_prj_unit_price");
            AvgActUnitPrice = reader.ReadDouble("avg_act_unit_price");
            AvgPrjActUnitPrice = reader.ReadDouble("avg_prj_act_unit_price");
            Allbrandcompanysuppressed = reader.ReadLong("allbrandcompanysuppressed");
            Allbrandsuppressed = reader.ReadLong("allbrandsuppressed");
            Allbrandfamilysuppressed = reader.ReadLong("allbrandfamilysuppressed");
            Allbrandderivedsuppressed = reader.ReadLong("allbrandderivedsuppressed");
            Allbrandcompany = reader.ReadLong("allbrandcompany");
            Allbrandderived = reader.ReadLong("allbrandderived");
            Alloutlet = reader.ReadLong("alloutlet");
            Altbusiness = reader.ReadLong("altbusiness");
            Alloutletfamily = reader.ReadLong("alloutletfamily");
            Retsupercategoryderived = reader.ReadLong("retsupercategoryderived");
            Retsubcategoryderived = reader.ReadLong("retsubcategoryderived");
            Rethidsubcategoryderived = reader.ReadLong("rethidsubcategoryderived");
            Wearerderived = reader.ReadLong("wearerderived");
            Allindustry = reader.ReadLong("allindustry");
            Wearergenderderived = reader.ReadLong("wearergenderderived");
            Allcategoryderived = reader.ReadLong("allcategoryderived");
            Allsector = reader.ReadLong("allsector");
            Alloutletderived = reader.ReadLong("alloutletderived");
            Allbrandfamily = reader.ReadLong("allbrandfamily");
            Allbrand = reader.ReadLong("allbrand");
            Retcategoryderived = reader.ReadLong("retcategoryderived");
            Allsubcategoryderived = reader.ReadLong("allsubcategoryderived");
            Retcategorygroupderived = reader.ReadLong("retcategorygroupderived");
            Bbysubclass = reader.ReadLong("bbysubclass");
            Bbymerchantlevel = reader.ReadLong("bbymerchantlevel");
            Bbyvplevel = reader.ReadLong("bbyvplevel");
            Bbydepartment = reader.ReadLong("bbydepartment");
            Bbyclass = reader.ReadLong("bbyclass");
            Bbybusinessgroup = reader.ReadLong("bbybusinessgroup");
            AvgPrjActUnitPriceOutlet = reader.ReadDouble("avg_prj_act_unit_price_outlet");
            AvgActUnitPriceChannel = reader.ReadDouble("avg_act_unit_price_channel");
            AvgPrjActUnitPriceChannel = reader.ReadDouble("avg_prj_act_unit_price_channel");
            AvgUnitPriceOutlet = reader.ReadDouble("avg_unit_price_outlet");
            AvgPrjUnitPriceChannel = reader.ReadDouble("avg_prj_unit_price_channel");
            AvgUnitPriceChannel = reader.ReadDouble("avg_unit_price_channel");
            AvgActUnitPriceOutlet = reader.ReadDouble("avg_act_unit_price_outlet");
            AvgPrjUnitPriceOutlet = reader.ReadDouble("avg_prj_unit_price_outlet");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Ppweek = *(long*) (p + 0);
                Ppmonth = *(long*) (p + 8);
                Country = *(long*) (p + 16);
                Itemid = *(long*) (p + 24);
                Loadid = *(long*) (p + 32);
                PosId = *(long*) (p + 40);
                Rid = *(long*) (p + 48);
                Posoutlet = *(long*) (p + 56);
                Storeid = Encoding.ASCII.GetString(buffer, 64, 64).TrimEnd();
                Postalcode = Encoding.ASCII.GetString(buffer, 128, 64).TrimEnd();
                Outletstoreid = Encoding.ASCII.GetString(buffer, 192, 64).TrimEnd();
                RetailerItemId = *(long*) (p + 256);
                Sku = Encoding.ASCII.GetString(buffer, 264, 64).TrimEnd();
                Itemnumber = *(long*) (p + 328);
                Wearertype = *(long*) (p + 336);
                Wearersubtype = *(long*) (p + 344);
                Wearersize = *(long*) (p + 352);
                Retailerregion = *(long*) (p + 360);
                Wearersegment = *(long*) (p + 368);
                Wearergender = *(long*) (p + 376);
                Superchannel = *(long*) (p + 384);
                Supercategory = *(long*) (p + 392);
                Subclass = *(long*) (p + 400);
                Outletfamily = *(long*) (p + 408);
                Outlet = *(long*) (p + 416);
                Subchannel = *(long*) (p + 424);
                Company = *(long*) (p + 432);
                Classification = *(long*) (p + 440);
                Class = *(long*) (p + 448);
                Channel = *(long*) (p + 456);
                Categorytype = *(long*) (p + 464);
                Category = *(long*) (p + 472);
                Brandtype = *(long*) (p + 480);
                Brandfamily = *(long*) (p + 488);
                Brand = *(long*) (p + 496);
                Itemnumbersuppressed = *(long*) (p + 504);
                Brandfamilysuppressed = *(long*) (p + 512);
                BrandfamilysuppressedOrg = *(long*) (p + 520);
                Brandfamilysuppressednc = *(long*) (p + 528);
                BrandfamilysuppressedncOrg = *(long*) (p + 536);
                Brandsuppressed = *(long*) (p + 544);
                BrandsuppressedOrg = *(long*) (p + 552);
                Brandsuppressednc = *(long*) (p + 560);
                BrandsuppressedncOrg = *(long*) (p + 568);
                ItemnumbersuppressedOrg = *(long*) (p + 576);
                Brandtypesuppressed = *(long*) (p + 584);
                BrandtypesuppressedOrg = *(long*) (p + 592);
                Brandtypesuppressednc = *(long*) (p + 600);
                BrandtypesuppressedncOrg = *(long*) (p + 608);
                Itemnumbersuppressednc = *(long*) (p + 616);
                ItemnumbersuppressedncOrg = *(long*) (p + 624);
                Introdate = *(long*) (p + 632);
                Censusregionusa = *(long*) (p + 640);
                Censusdivisionusa = *(long*) (p + 648);
                State = *(long*) (p + 656);
                Dma = *(long*) (p + 664);
                Cbsa = *(long*) (p + 672);
                Distributor = *(long*) (p + 680);
                Year = *(long*) (p + 688);
                Yearhalf = *(long*) (p + 696);
                Yearqtr = *(long*) (p + 704);
                Yearmonth = *(long*) (p + 712);
                Yearweek = *(long*) (p + 720);
                RawInventory = *(double*) (p + 728);
                RawUnitssold = *(double*) (p + 736);
                RawTotalvalue = *(double*) (p + 744);
                Inventory = *(double*) (p + 752);
                Unitssold = *(double*) (p + 760);
                Totalvalue = *(double*) (p + 768);
                Trans = *(double*) (p + 776);
                ProjInventory = *(double*) (p + 784);
                ProjUnitssold = *(double*) (p + 792);
                ProjTotalvalue = *(double*) (p + 800);
                StoresTotalvalue = *(double*) (p + 808);
                TotindStoresTotalvalue = *(double*) (p + 816);
                TotindProjStoresTotalvalue = *(double*) (p + 824);
                ProjStoresTotalvalue = *(double*) (p + 832);
                UnitsPerPackage = *(double*) (p + 840);
                StoresTotalvalueFactor = *(double*) (p + 848);
                UnitPrice = *(double*) (p + 856);
                ProjUnitPrice = *(double*) (p + 864);
                UpcCode = Encoding.ASCII.GetString(buffer, 872, 64).TrimEnd();
                UpcType = Encoding.ASCII.GetString(buffer, 936, 64).TrimEnd();
                StoreSublvlTotalvalue = *(double*) (p + 1000);
                PostalSublvlTotalvalue = *(double*) (p + 1008);
                Outletpostalcode = Encoding.ASCII.GetString(buffer, 1016, 64).TrimEnd();
                Skusuppressed = Encoding.ASCII.GetString(buffer, 1080, 64).TrimEnd();
                Itemidsuppressed = Encoding.ASCII.GetString(buffer, 1144, 64).TrimEnd();
                RetailerItemIdsuppressed = *(long*) (p + 1208);
                RetailerItemIdsuppressednc = *(long*) (p + 1216);
                Itemidsuppressednc = Encoding.ASCII.GetString(buffer, 1224, 64).TrimEnd();
                Skusuppressednc = Encoding.ASCII.GetString(buffer, 1288, 64).TrimEnd();
                UpcCodesuppressednc = Encoding.ASCII.GetString(buffer, 1352, 64).TrimEnd();
                UpcCodesuppressed = Encoding.ASCII.GetString(buffer, 1416, 64).TrimEnd();
                RactuntsAdj = *(double*) (p + 1480);
                RunitsAdj = *(double*) (p + 1488);
                UnitsAdj = *(double*) (p + 1496);
                RdollarsAdj = *(double*) (p + 1504);
                DollarsAdj = *(double*) (p + 1512);
                Outletallocation = *(long*) (p + 1520);
                ActuntsAdj = *(double*) (p + 1528);
                ActualUnits = *(double*) (p + 1536);
                ProjActualUnits = *(double*) (p + 1544);
                Numweeks = *(long*) (p + 1552);
                StoreWeight = Encoding.ASCII.GetString(buffer, 1560, 64).TrimEnd();
                AvgUnitPrice = *(double*) (p + 1624);
                AvgPrjUnitPrice = *(double*) (p + 1632);
                AvgActUnitPrice = *(double*) (p + 1640);
                AvgPrjActUnitPrice = *(double*) (p + 1648);
                Allbrandcompanysuppressed = *(long*) (p + 1656);
                Allbrandsuppressed = *(long*) (p + 1664);
                Allbrandfamilysuppressed = *(long*) (p + 1672);
                Allbrandderivedsuppressed = *(long*) (p + 1680);
                Allbrandcompany = *(long*) (p + 1688);
                Allbrandderived = *(long*) (p + 1696);
                Alloutlet = *(long*) (p + 1704);
                Altbusiness = *(long*) (p + 1712);
                Alloutletfamily = *(long*) (p + 1720);
                Retsupercategoryderived = *(long*) (p + 1728);
                Retsubcategoryderived = *(long*) (p + 1736);
                Rethidsubcategoryderived = *(long*) (p + 1744);
                Wearerderived = *(long*) (p + 1752);
                Allindustry = *(long*) (p + 1760);
                Wearergenderderived = *(long*) (p + 1768);
                Allcategoryderived = *(long*) (p + 1776);
                Allsector = *(long*) (p + 1784);
                Alloutletderived = *(long*) (p + 1792);
                Allbrandfamily = *(long*) (p + 1800);
                Allbrand = *(long*) (p + 1808);
                Retcategoryderived = *(long*) (p + 1816);
                Allsubcategoryderived = *(long*) (p + 1824);
                Retcategorygroupderived = *(long*) (p + 1832);
                Bbysubclass = *(long*) (p + 1840);
                Bbymerchantlevel = *(long*) (p + 1848);
                Bbyvplevel = *(long*) (p + 1856);
                Bbydepartment = *(long*) (p + 1864);
                Bbyclass = *(long*) (p + 1872);
                Bbybusinessgroup = *(long*) (p + 1880);
                AvgPrjActUnitPriceOutlet = *(double*) (p + 1888);
                AvgActUnitPriceChannel = *(double*) (p + 1896);
                AvgPrjActUnitPriceChannel = *(double*) (p + 1904);
                AvgUnitPriceOutlet = *(double*) (p + 1912);
                AvgPrjUnitPriceChannel = *(double*) (p + 1920);
                AvgUnitPriceChannel = *(double*) (p + 1928);
                AvgActUnitPriceOutlet = *(double*) (p + 1936);
                AvgPrjUnitPriceOutlet = *(double*) (p + 1944);
            }
        }
    }
}
