// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class FactPosdataMon : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "ppmonth")] public long Ppmonth { get; set; }
        [QuerySqlField(Name = "ppweek")] public long Ppweek { get; set; }
        [QuerySqlField(Name = "country")] public long Country { get; set; }
        [QuerySqlField(Name = "itemid")] public long Itemid { get; set; }
        [QuerySqlField(Name = "loadid")] public long Loadid { get; set; }
        [QuerySqlField(Name = "retailer_item_id")] public long RetailerItemId { get; set; }
        [QuerySqlField(Name = "sku")] public string Sku { get; set; }
        [QuerySqlField(Name = "itemnumber")] public long Itemnumber { get; set; }
        [QuerySqlField(Name = "company")] public long Company { get; set; }
        [QuerySqlField(Name = "classification")] public long Classification { get; set; }
        [QuerySqlField(Name = "class")] public long Class { get; set; }
        [QuerySqlField(Name = "channel")] public long Channel { get; set; }
        [QuerySqlField(Name = "categorytype")] public long Categorytype { get; set; }
        [QuerySqlField(Name = "superchannel")] public long Superchannel { get; set; }
        [QuerySqlField(Name = "supercategory")] public long Supercategory { get; set; }
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "subchannel")] public long Subchannel { get; set; }
        [QuerySqlField(Name = "category")] public long Category { get; set; }
        [QuerySqlField(Name = "brandtype")] public long Brandtype { get; set; }
        [QuerySqlField(Name = "brandfamily")] public long Brandfamily { get; set; }
        [QuerySqlField(Name = "wearertype")] public long Wearertype { get; set; }
        [QuerySqlField(Name = "retailerregion")] public long Retailerregion { get; set; }
        [QuerySqlField(Name = "wearersubtype")] public long Wearersubtype { get; set; }
        [QuerySqlField(Name = "brand")] public long Brand { get; set; }
        [QuerySqlField(Name = "wearersize")] public long Wearersize { get; set; }
        [QuerySqlField(Name = "outlet")] public long Outlet { get; set; }
        [QuerySqlField(Name = "outletfamily")] public long Outletfamily { get; set; }
        [QuerySqlField(Name = "wearersegment")] public long Wearersegment { get; set; }
        [QuerySqlField(Name = "wearergender")] public long Wearergender { get; set; }
        [QuerySqlField(Name = "introdate")] public long Introdate { get; set; }
        [QuerySqlField(Name = "itemnumbersuppressednc_org")] public long ItemnumbersuppressedncOrg { get; set; }
        [QuerySqlField(Name = "itemnumbersuppressed_org")] public long ItemnumbersuppressedOrg { get; set; }
        [QuerySqlField(Name = "itemnumbersuppressed")] public long Itemnumbersuppressed { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressed")] public long Brandfamilysuppressed { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressed_org")] public long BrandfamilysuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressednc")] public long Brandfamilysuppressednc { get; set; }
        [QuerySqlField(Name = "brandfamilysuppressednc_org")] public long BrandfamilysuppressedncOrg { get; set; }
        [QuerySqlField(Name = "brandsuppressed")] public long Brandsuppressed { get; set; }
        [QuerySqlField(Name = "brandsuppressed_org")] public long BrandsuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandsuppressednc")] public long Brandsuppressednc { get; set; }
        [QuerySqlField(Name = "brandsuppressednc_org")] public long BrandsuppressedncOrg { get; set; }
        [QuerySqlField(Name = "itemnumbersuppressednc")] public long Itemnumbersuppressednc { get; set; }
        [QuerySqlField(Name = "brandtypesuppressed")] public long Brandtypesuppressed { get; set; }
        [QuerySqlField(Name = "brandtypesuppressed_org")] public long BrandtypesuppressedOrg { get; set; }
        [QuerySqlField(Name = "brandtypesuppressednc")] public long Brandtypesuppressednc { get; set; }
        [QuerySqlField(Name = "brandtypesuppressednc_org")] public long BrandtypesuppressedncOrg { get; set; }
        [QuerySqlField(Name = "year")] public long Year { get; set; }
        [QuerySqlField(Name = "yearhalf")] public long Yearhalf { get; set; }
        [QuerySqlField(Name = "yearqtr")] public long Yearqtr { get; set; }
        [QuerySqlField(Name = "yearmonth")] public long Yearmonth { get; set; }
        [QuerySqlField(Name = "yearweek")] public long Yearweek { get; set; }
        [QuerySqlField(Name = "distributor")] public long Distributor { get; set; }
        [QuerySqlField(Name = "stores_in_chain")] public long StoresInChain { get; set; }
        [QuerySqlField(Name = "stores_selling")] public long StoresSelling { get; set; }
        [QuerySqlField(Name = "stores_stocking")] public long StoresStocking { get; set; }
        [QuerySqlField(Name = "upc_code")] public string UpcCode { get; set; }
        [QuerySqlField(Name = "upc_type")] public string UpcType { get; set; }
        [QuerySqlField(Name = "raw_inventory")] public double RawInventory { get; set; }
        [QuerySqlField(Name = "raw_totalvalue")] public double RawTotalvalue { get; set; }
        [QuerySqlField(Name = "raw_unitssold")] public double RawUnitssold { get; set; }
        [QuerySqlField(Name = "inventory")] public double Inventory { get; set; }
        [QuerySqlField(Name = "totalvalue")] public double Totalvalue { get; set; }
        [QuerySqlField(Name = "unitssold")] public double Unitssold { get; set; }
        [QuerySqlField(Name = "trans")] public double Trans { get; set; }
        [QuerySqlField(Name = "proj_inventory")] public double ProjInventory { get; set; }
        [QuerySqlField(Name = "proj_totalvalue")] public double ProjTotalvalue { get; set; }
        [QuerySqlField(Name = "proj_unitssold")] public double ProjUnitssold { get; set; }
        [QuerySqlField(Name = "unit_price")] public double UnitPrice { get; set; }
        [QuerySqlField(Name = "proj_unit_price")] public double ProjUnitPrice { get; set; }
        [QuerySqlField(Name = "units_per_package")] public double UnitsPerPackage { get; set; }
        [QuerySqlField(Name = "outletallocation")] public long Outletallocation { get; set; }
        [QuerySqlField(Name = "units_adj")] public double UnitsAdj { get; set; }
        [QuerySqlField(Name = "actunts_adj")] public double ActuntsAdj { get; set; }
        [QuerySqlField(Name = "upc_codesuppressed")] public string UpcCodesuppressed { get; set; }
        [QuerySqlField(Name = "dollars_adj")] public double DollarsAdj { get; set; }
        [QuerySqlField(Name = "itemidsuppressed")] public string Itemidsuppressed { get; set; }
        [QuerySqlField(Name = "ractunts_adj")] public double RactuntsAdj { get; set; }
        [QuerySqlField(Name = "upc_codesuppressednc")] public string UpcCodesuppressednc { get; set; }
        [QuerySqlField(Name = "skusuppressednc")] public string Skusuppressednc { get; set; }
        [QuerySqlField(Name = "rdollars_adj")] public double RdollarsAdj { get; set; }
        [QuerySqlField(Name = "retailer_item_idsuppressed")] public long RetailerItemIdsuppressed { get; set; }
        [QuerySqlField(Name = "retailer_item_idsuppressednc")] public long RetailerItemIdsuppressednc { get; set; }
        [QuerySqlField(Name = "runits_adj")] public double RunitsAdj { get; set; }
        [QuerySqlField(Name = "skusuppressed")] public string Skusuppressed { get; set; }
        [QuerySqlField(Name = "itemidsuppressednc")] public string Itemidsuppressednc { get; set; }
        [QuerySqlField(Name = "actual_units")] public double ActualUnits { get; set; }
        [QuerySqlField(Name = "proj_actual_units")] public double ProjActualUnits { get; set; }
        [QuerySqlField(Name = "numweeks")] public long Numweeks { get; set; }
        [QuerySqlField(Name = "allbrandfamilysuppressed")] public long Allbrandfamilysuppressed { get; set; }
        [QuerySqlField(Name = "allbrandcompanysuppressed")] public long Allbrandcompanysuppressed { get; set; }
        [QuerySqlField(Name = "allbrandderivedsuppressed")] public long Allbrandderivedsuppressed { get; set; }
        [QuerySqlField(Name = "allbrandsuppressed")] public long Allbrandsuppressed { get; set; }
        [QuerySqlField(Name = "retcategorygroupderived")] public long Retcategorygroupderived { get; set; }
        [QuerySqlField(Name = "rethidsubcategoryderived")] public long Rethidsubcategoryderived { get; set; }
        [QuerySqlField(Name = "retsubcategoryderived")] public long Retsubcategoryderived { get; set; }
        [QuerySqlField(Name = "retsupercategoryderived")] public long Retsupercategoryderived { get; set; }
        [QuerySqlField(Name = "wearerderived")] public long Wearerderived { get; set; }
        [QuerySqlField(Name = "allbrandderived")] public long Allbrandderived { get; set; }
        [QuerySqlField(Name = "alloutlet")] public long Alloutlet { get; set; }
        [QuerySqlField(Name = "allcategoryderived")] public long Allcategoryderived { get; set; }
        [QuerySqlField(Name = "allbrandcompany")] public long Allbrandcompany { get; set; }
        [QuerySqlField(Name = "wearergenderderived")] public long Wearergenderderived { get; set; }
        [QuerySqlField(Name = "allbrand")] public long Allbrand { get; set; }
        [QuerySqlField(Name = "alloutletderived")] public long Alloutletderived { get; set; }
        [QuerySqlField(Name = "alloutletfamily")] public long Alloutletfamily { get; set; }
        [QuerySqlField(Name = "allbrandfamily")] public long Allbrandfamily { get; set; }
        [QuerySqlField(Name = "allindustry")] public long Allindustry { get; set; }
        [QuerySqlField(Name = "altbusiness")] public long Altbusiness { get; set; }
        [QuerySqlField(Name = "allsubcategoryderived")] public long Allsubcategoryderived { get; set; }
        [QuerySqlField(Name = "allsector")] public long Allsector { get; set; }
        [QuerySqlField(Name = "retcategoryderived")] public long Retcategoryderived { get; set; }
        [QuerySqlField(Name = "bbysubclass")] public long Bbysubclass { get; set; }
        [QuerySqlField(Name = "bbyvplevel")] public long Bbyvplevel { get; set; }
        [QuerySqlField(Name = "bbymerchantlevel")] public long Bbymerchantlevel { get; set; }
        [QuerySqlField(Name = "bbydepartment")] public long Bbydepartment { get; set; }
        [QuerySqlField(Name = "bbyclass")] public long Bbyclass { get; set; }
        [QuerySqlField(Name = "bbybusinessgroup")] public long Bbybusinessgroup { get; set; }
        [QuerySqlField(Name = "rid")] public long Rid { get; set; }
        [QuerySqlField(Name = "posoutlet")] public long Posoutlet { get; set; }
        [QuerySqlField(Name = "pos_id")] public long PosId { get; set; }
        [QuerySqlField(Name = "avg_unit_price")] public double AvgUnitPrice { get; set; }
        [QuerySqlField(Name = "avg_prj_unit_price")] public double AvgPrjUnitPrice { get; set; }
        [QuerySqlField(Name = "avg_act_unit_price")] public double AvgActUnitPrice { get; set; }
        [QuerySqlField(Name = "avg_prj_act_unit_price")] public double AvgPrjActUnitPrice { get; set; }
        [QuerySqlField(Name = "avg_prj_act_unit_price_outlet")] public double AvgPrjActUnitPriceOutlet { get; set; }
        [QuerySqlField(Name = "avg_act_unit_price_outlet")] public double AvgActUnitPriceOutlet { get; set; }
        [QuerySqlField(Name = "avg_act_unit_price_channel")] public double AvgActUnitPriceChannel { get; set; }
        [QuerySqlField(Name = "avg_prj_unit_price_channel")] public double AvgPrjUnitPriceChannel { get; set; }
        [QuerySqlField(Name = "avg_prj_unit_price_outlet")] public double AvgPrjUnitPriceOutlet { get; set; }
        [QuerySqlField(Name = "avg_prj_act_unit_price_channel")] public double AvgPrjActUnitPriceChannel { get; set; }
        [QuerySqlField(Name = "avg_unit_price_channel")] public double AvgUnitPriceChannel { get; set; }
        [QuerySqlField(Name = "avg_unit_price_outlet")] public double AvgUnitPriceOutlet { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("ppmonth", Ppmonth);
            writer.WriteLong("ppweek", Ppweek);
            writer.WriteLong("country", Country);
            writer.WriteLong("itemid", Itemid);
            writer.WriteLong("loadid", Loadid);
            writer.WriteLong("retailer_item_id", RetailerItemId);
            writer.WriteString("sku", Sku);
            writer.WriteLong("itemnumber", Itemnumber);
            writer.WriteLong("company", Company);
            writer.WriteLong("classification", Classification);
            writer.WriteLong("class", Class);
            writer.WriteLong("channel", Channel);
            writer.WriteLong("categorytype", Categorytype);
            writer.WriteLong("superchannel", Superchannel);
            writer.WriteLong("supercategory", Supercategory);
            writer.WriteLong("subclass", Subclass);
            writer.WriteLong("subchannel", Subchannel);
            writer.WriteLong("category", Category);
            writer.WriteLong("brandtype", Brandtype);
            writer.WriteLong("brandfamily", Brandfamily);
            writer.WriteLong("wearertype", Wearertype);
            writer.WriteLong("retailerregion", Retailerregion);
            writer.WriteLong("wearersubtype", Wearersubtype);
            writer.WriteLong("brand", Brand);
            writer.WriteLong("wearersize", Wearersize);
            writer.WriteLong("outlet", Outlet);
            writer.WriteLong("outletfamily", Outletfamily);
            writer.WriteLong("wearersegment", Wearersegment);
            writer.WriteLong("wearergender", Wearergender);
            writer.WriteLong("introdate", Introdate);
            writer.WriteLong("itemnumbersuppressednc_org", ItemnumbersuppressedncOrg);
            writer.WriteLong("itemnumbersuppressed_org", ItemnumbersuppressedOrg);
            writer.WriteLong("itemnumbersuppressed", Itemnumbersuppressed);
            writer.WriteLong("brandfamilysuppressed", Brandfamilysuppressed);
            writer.WriteLong("brandfamilysuppressed_org", BrandfamilysuppressedOrg);
            writer.WriteLong("brandfamilysuppressednc", Brandfamilysuppressednc);
            writer.WriteLong("brandfamilysuppressednc_org", BrandfamilysuppressedncOrg);
            writer.WriteLong("brandsuppressed", Brandsuppressed);
            writer.WriteLong("brandsuppressed_org", BrandsuppressedOrg);
            writer.WriteLong("brandsuppressednc", Brandsuppressednc);
            writer.WriteLong("brandsuppressednc_org", BrandsuppressedncOrg);
            writer.WriteLong("itemnumbersuppressednc", Itemnumbersuppressednc);
            writer.WriteLong("brandtypesuppressed", Brandtypesuppressed);
            writer.WriteLong("brandtypesuppressed_org", BrandtypesuppressedOrg);
            writer.WriteLong("brandtypesuppressednc", Brandtypesuppressednc);
            writer.WriteLong("brandtypesuppressednc_org", BrandtypesuppressedncOrg);
            writer.WriteLong("year", Year);
            writer.WriteLong("yearhalf", Yearhalf);
            writer.WriteLong("yearqtr", Yearqtr);
            writer.WriteLong("yearmonth", Yearmonth);
            writer.WriteLong("yearweek", Yearweek);
            writer.WriteLong("distributor", Distributor);
            writer.WriteLong("stores_in_chain", StoresInChain);
            writer.WriteLong("stores_selling", StoresSelling);
            writer.WriteLong("stores_stocking", StoresStocking);
            writer.WriteString("upc_code", UpcCode);
            writer.WriteString("upc_type", UpcType);
            writer.WriteDouble("raw_inventory", RawInventory);
            writer.WriteDouble("raw_totalvalue", RawTotalvalue);
            writer.WriteDouble("raw_unitssold", RawUnitssold);
            writer.WriteDouble("inventory", Inventory);
            writer.WriteDouble("totalvalue", Totalvalue);
            writer.WriteDouble("unitssold", Unitssold);
            writer.WriteDouble("trans", Trans);
            writer.WriteDouble("proj_inventory", ProjInventory);
            writer.WriteDouble("proj_totalvalue", ProjTotalvalue);
            writer.WriteDouble("proj_unitssold", ProjUnitssold);
            writer.WriteDouble("unit_price", UnitPrice);
            writer.WriteDouble("proj_unit_price", ProjUnitPrice);
            writer.WriteDouble("units_per_package", UnitsPerPackage);
            writer.WriteLong("outletallocation", Outletallocation);
            writer.WriteDouble("units_adj", UnitsAdj);
            writer.WriteDouble("actunts_adj", ActuntsAdj);
            writer.WriteString("upc_codesuppressed", UpcCodesuppressed);
            writer.WriteDouble("dollars_adj", DollarsAdj);
            writer.WriteString("itemidsuppressed", Itemidsuppressed);
            writer.WriteDouble("ractunts_adj", RactuntsAdj);
            writer.WriteString("upc_codesuppressednc", UpcCodesuppressednc);
            writer.WriteString("skusuppressednc", Skusuppressednc);
            writer.WriteDouble("rdollars_adj", RdollarsAdj);
            writer.WriteLong("retailer_item_idsuppressed", RetailerItemIdsuppressed);
            writer.WriteLong("retailer_item_idsuppressednc", RetailerItemIdsuppressednc);
            writer.WriteDouble("runits_adj", RunitsAdj);
            writer.WriteString("skusuppressed", Skusuppressed);
            writer.WriteString("itemidsuppressednc", Itemidsuppressednc);
            writer.WriteDouble("actual_units", ActualUnits);
            writer.WriteDouble("proj_actual_units", ProjActualUnits);
            writer.WriteLong("numweeks", Numweeks);
            writer.WriteLong("allbrandfamilysuppressed", Allbrandfamilysuppressed);
            writer.WriteLong("allbrandcompanysuppressed", Allbrandcompanysuppressed);
            writer.WriteLong("allbrandderivedsuppressed", Allbrandderivedsuppressed);
            writer.WriteLong("allbrandsuppressed", Allbrandsuppressed);
            writer.WriteLong("retcategorygroupderived", Retcategorygroupderived);
            writer.WriteLong("rethidsubcategoryderived", Rethidsubcategoryderived);
            writer.WriteLong("retsubcategoryderived", Retsubcategoryderived);
            writer.WriteLong("retsupercategoryderived", Retsupercategoryderived);
            writer.WriteLong("wearerderived", Wearerderived);
            writer.WriteLong("allbrandderived", Allbrandderived);
            writer.WriteLong("alloutlet", Alloutlet);
            writer.WriteLong("allcategoryderived", Allcategoryderived);
            writer.WriteLong("allbrandcompany", Allbrandcompany);
            writer.WriteLong("wearergenderderived", Wearergenderderived);
            writer.WriteLong("allbrand", Allbrand);
            writer.WriteLong("alloutletderived", Alloutletderived);
            writer.WriteLong("alloutletfamily", Alloutletfamily);
            writer.WriteLong("allbrandfamily", Allbrandfamily);
            writer.WriteLong("allindustry", Allindustry);
            writer.WriteLong("altbusiness", Altbusiness);
            writer.WriteLong("allsubcategoryderived", Allsubcategoryderived);
            writer.WriteLong("allsector", Allsector);
            writer.WriteLong("retcategoryderived", Retcategoryderived);
            writer.WriteLong("bbysubclass", Bbysubclass);
            writer.WriteLong("bbyvplevel", Bbyvplevel);
            writer.WriteLong("bbymerchantlevel", Bbymerchantlevel);
            writer.WriteLong("bbydepartment", Bbydepartment);
            writer.WriteLong("bbyclass", Bbyclass);
            writer.WriteLong("bbybusinessgroup", Bbybusinessgroup);
            writer.WriteLong("rid", Rid);
            writer.WriteLong("posoutlet", Posoutlet);
            writer.WriteLong("pos_id", PosId);
            writer.WriteDouble("avg_unit_price", AvgUnitPrice);
            writer.WriteDouble("avg_prj_unit_price", AvgPrjUnitPrice);
            writer.WriteDouble("avg_act_unit_price", AvgActUnitPrice);
            writer.WriteDouble("avg_prj_act_unit_price", AvgPrjActUnitPrice);
            writer.WriteDouble("avg_prj_act_unit_price_outlet", AvgPrjActUnitPriceOutlet);
            writer.WriteDouble("avg_act_unit_price_outlet", AvgActUnitPriceOutlet);
            writer.WriteDouble("avg_act_unit_price_channel", AvgActUnitPriceChannel);
            writer.WriteDouble("avg_prj_unit_price_channel", AvgPrjUnitPriceChannel);
            writer.WriteDouble("avg_prj_unit_price_outlet", AvgPrjUnitPriceOutlet);
            writer.WriteDouble("avg_prj_act_unit_price_channel", AvgPrjActUnitPriceChannel);
            writer.WriteDouble("avg_unit_price_channel", AvgUnitPriceChannel);
            writer.WriteDouble("avg_unit_price_outlet", AvgUnitPriceOutlet);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppmonth = reader.ReadLong("ppmonth");
            Ppweek = reader.ReadLong("ppweek");
            Country = reader.ReadLong("country");
            Itemid = reader.ReadLong("itemid");
            Loadid = reader.ReadLong("loadid");
            RetailerItemId = reader.ReadLong("retailer_item_id");
            Sku = reader.ReadString("sku");
            Itemnumber = reader.ReadLong("itemnumber");
            Company = reader.ReadLong("company");
            Classification = reader.ReadLong("classification");
            Class = reader.ReadLong("class");
            Channel = reader.ReadLong("channel");
            Categorytype = reader.ReadLong("categorytype");
            Superchannel = reader.ReadLong("superchannel");
            Supercategory = reader.ReadLong("supercategory");
            Subclass = reader.ReadLong("subclass");
            Subchannel = reader.ReadLong("subchannel");
            Category = reader.ReadLong("category");
            Brandtype = reader.ReadLong("brandtype");
            Brandfamily = reader.ReadLong("brandfamily");
            Wearertype = reader.ReadLong("wearertype");
            Retailerregion = reader.ReadLong("retailerregion");
            Wearersubtype = reader.ReadLong("wearersubtype");
            Brand = reader.ReadLong("brand");
            Wearersize = reader.ReadLong("wearersize");
            Outlet = reader.ReadLong("outlet");
            Outletfamily = reader.ReadLong("outletfamily");
            Wearersegment = reader.ReadLong("wearersegment");
            Wearergender = reader.ReadLong("wearergender");
            Introdate = reader.ReadLong("introdate");
            ItemnumbersuppressedncOrg = reader.ReadLong("itemnumbersuppressednc_org");
            ItemnumbersuppressedOrg = reader.ReadLong("itemnumbersuppressed_org");
            Itemnumbersuppressed = reader.ReadLong("itemnumbersuppressed");
            Brandfamilysuppressed = reader.ReadLong("brandfamilysuppressed");
            BrandfamilysuppressedOrg = reader.ReadLong("brandfamilysuppressed_org");
            Brandfamilysuppressednc = reader.ReadLong("brandfamilysuppressednc");
            BrandfamilysuppressedncOrg = reader.ReadLong("brandfamilysuppressednc_org");
            Brandsuppressed = reader.ReadLong("brandsuppressed");
            BrandsuppressedOrg = reader.ReadLong("brandsuppressed_org");
            Brandsuppressednc = reader.ReadLong("brandsuppressednc");
            BrandsuppressedncOrg = reader.ReadLong("brandsuppressednc_org");
            Itemnumbersuppressednc = reader.ReadLong("itemnumbersuppressednc");
            Brandtypesuppressed = reader.ReadLong("brandtypesuppressed");
            BrandtypesuppressedOrg = reader.ReadLong("brandtypesuppressed_org");
            Brandtypesuppressednc = reader.ReadLong("brandtypesuppressednc");
            BrandtypesuppressedncOrg = reader.ReadLong("brandtypesuppressednc_org");
            Year = reader.ReadLong("year");
            Yearhalf = reader.ReadLong("yearhalf");
            Yearqtr = reader.ReadLong("yearqtr");
            Yearmonth = reader.ReadLong("yearmonth");
            Yearweek = reader.ReadLong("yearweek");
            Distributor = reader.ReadLong("distributor");
            StoresInChain = reader.ReadLong("stores_in_chain");
            StoresSelling = reader.ReadLong("stores_selling");
            StoresStocking = reader.ReadLong("stores_stocking");
            UpcCode = reader.ReadString("upc_code");
            UpcType = reader.ReadString("upc_type");
            RawInventory = reader.ReadDouble("raw_inventory");
            RawTotalvalue = reader.ReadDouble("raw_totalvalue");
            RawUnitssold = reader.ReadDouble("raw_unitssold");
            Inventory = reader.ReadDouble("inventory");
            Totalvalue = reader.ReadDouble("totalvalue");
            Unitssold = reader.ReadDouble("unitssold");
            Trans = reader.ReadDouble("trans");
            ProjInventory = reader.ReadDouble("proj_inventory");
            ProjTotalvalue = reader.ReadDouble("proj_totalvalue");
            ProjUnitssold = reader.ReadDouble("proj_unitssold");
            UnitPrice = reader.ReadDouble("unit_price");
            ProjUnitPrice = reader.ReadDouble("proj_unit_price");
            UnitsPerPackage = reader.ReadDouble("units_per_package");
            Outletallocation = reader.ReadLong("outletallocation");
            UnitsAdj = reader.ReadDouble("units_adj");
            ActuntsAdj = reader.ReadDouble("actunts_adj");
            UpcCodesuppressed = reader.ReadString("upc_codesuppressed");
            DollarsAdj = reader.ReadDouble("dollars_adj");
            Itemidsuppressed = reader.ReadString("itemidsuppressed");
            RactuntsAdj = reader.ReadDouble("ractunts_adj");
            UpcCodesuppressednc = reader.ReadString("upc_codesuppressednc");
            Skusuppressednc = reader.ReadString("skusuppressednc");
            RdollarsAdj = reader.ReadDouble("rdollars_adj");
            RetailerItemIdsuppressed = reader.ReadLong("retailer_item_idsuppressed");
            RetailerItemIdsuppressednc = reader.ReadLong("retailer_item_idsuppressednc");
            RunitsAdj = reader.ReadDouble("runits_adj");
            Skusuppressed = reader.ReadString("skusuppressed");
            Itemidsuppressednc = reader.ReadString("itemidsuppressednc");
            ActualUnits = reader.ReadDouble("actual_units");
            ProjActualUnits = reader.ReadDouble("proj_actual_units");
            Numweeks = reader.ReadLong("numweeks");
            Allbrandfamilysuppressed = reader.ReadLong("allbrandfamilysuppressed");
            Allbrandcompanysuppressed = reader.ReadLong("allbrandcompanysuppressed");
            Allbrandderivedsuppressed = reader.ReadLong("allbrandderivedsuppressed");
            Allbrandsuppressed = reader.ReadLong("allbrandsuppressed");
            Retcategorygroupderived = reader.ReadLong("retcategorygroupderived");
            Rethidsubcategoryderived = reader.ReadLong("rethidsubcategoryderived");
            Retsubcategoryderived = reader.ReadLong("retsubcategoryderived");
            Retsupercategoryderived = reader.ReadLong("retsupercategoryderived");
            Wearerderived = reader.ReadLong("wearerderived");
            Allbrandderived = reader.ReadLong("allbrandderived");
            Alloutlet = reader.ReadLong("alloutlet");
            Allcategoryderived = reader.ReadLong("allcategoryderived");
            Allbrandcompany = reader.ReadLong("allbrandcompany");
            Wearergenderderived = reader.ReadLong("wearergenderderived");
            Allbrand = reader.ReadLong("allbrand");
            Alloutletderived = reader.ReadLong("alloutletderived");
            Alloutletfamily = reader.ReadLong("alloutletfamily");
            Allbrandfamily = reader.ReadLong("allbrandfamily");
            Allindustry = reader.ReadLong("allindustry");
            Altbusiness = reader.ReadLong("altbusiness");
            Allsubcategoryderived = reader.ReadLong("allsubcategoryderived");
            Allsector = reader.ReadLong("allsector");
            Retcategoryderived = reader.ReadLong("retcategoryderived");
            Bbysubclass = reader.ReadLong("bbysubclass");
            Bbyvplevel = reader.ReadLong("bbyvplevel");
            Bbymerchantlevel = reader.ReadLong("bbymerchantlevel");
            Bbydepartment = reader.ReadLong("bbydepartment");
            Bbyclass = reader.ReadLong("bbyclass");
            Bbybusinessgroup = reader.ReadLong("bbybusinessgroup");
            Rid = reader.ReadLong("rid");
            Posoutlet = reader.ReadLong("posoutlet");
            PosId = reader.ReadLong("pos_id");
            AvgUnitPrice = reader.ReadDouble("avg_unit_price");
            AvgPrjUnitPrice = reader.ReadDouble("avg_prj_unit_price");
            AvgActUnitPrice = reader.ReadDouble("avg_act_unit_price");
            AvgPrjActUnitPrice = reader.ReadDouble("avg_prj_act_unit_price");
            AvgPrjActUnitPriceOutlet = reader.ReadDouble("avg_prj_act_unit_price_outlet");
            AvgActUnitPriceOutlet = reader.ReadDouble("avg_act_unit_price_outlet");
            AvgActUnitPriceChannel = reader.ReadDouble("avg_act_unit_price_channel");
            AvgPrjUnitPriceChannel = reader.ReadDouble("avg_prj_unit_price_channel");
            AvgPrjUnitPriceOutlet = reader.ReadDouble("avg_prj_unit_price_outlet");
            AvgPrjActUnitPriceChannel = reader.ReadDouble("avg_prj_act_unit_price_channel");
            AvgUnitPriceChannel = reader.ReadDouble("avg_unit_price_channel");
            AvgUnitPriceOutlet = reader.ReadDouble("avg_unit_price_outlet");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Ppmonth = *(long*) (p + 0);
                Ppweek = *(long*) (p + 8);
                Country = *(long*) (p + 16);
                Itemid = *(long*) (p + 24);
                Loadid = *(long*) (p + 32);
                RetailerItemId = *(long*) (p + 40);
                Sku = Encoding.ASCII.GetString(buffer, 48, 64).TrimEnd();
                Itemnumber = *(long*) (p + 112);
                Company = *(long*) (p + 120);
                Classification = *(long*) (p + 128);
                Class = *(long*) (p + 136);
                Channel = *(long*) (p + 144);
                Categorytype = *(long*) (p + 152);
                Superchannel = *(long*) (p + 160);
                Supercategory = *(long*) (p + 168);
                Subclass = *(long*) (p + 176);
                Subchannel = *(long*) (p + 184);
                Category = *(long*) (p + 192);
                Brandtype = *(long*) (p + 200);
                Brandfamily = *(long*) (p + 208);
                Wearertype = *(long*) (p + 216);
                Retailerregion = *(long*) (p + 224);
                Wearersubtype = *(long*) (p + 232);
                Brand = *(long*) (p + 240);
                Wearersize = *(long*) (p + 248);
                Outlet = *(long*) (p + 256);
                Outletfamily = *(long*) (p + 264);
                Wearersegment = *(long*) (p + 272);
                Wearergender = *(long*) (p + 280);
                Introdate = *(long*) (p + 288);
                ItemnumbersuppressedncOrg = *(long*) (p + 296);
                ItemnumbersuppressedOrg = *(long*) (p + 304);
                Itemnumbersuppressed = *(long*) (p + 312);
                Brandfamilysuppressed = *(long*) (p + 320);
                BrandfamilysuppressedOrg = *(long*) (p + 328);
                Brandfamilysuppressednc = *(long*) (p + 336);
                BrandfamilysuppressedncOrg = *(long*) (p + 344);
                Brandsuppressed = *(long*) (p + 352);
                BrandsuppressedOrg = *(long*) (p + 360);
                Brandsuppressednc = *(long*) (p + 368);
                BrandsuppressedncOrg = *(long*) (p + 376);
                Itemnumbersuppressednc = *(long*) (p + 384);
                Brandtypesuppressed = *(long*) (p + 392);
                BrandtypesuppressedOrg = *(long*) (p + 400);
                Brandtypesuppressednc = *(long*) (p + 408);
                BrandtypesuppressedncOrg = *(long*) (p + 416);
                Year = *(long*) (p + 424);
                Yearhalf = *(long*) (p + 432);
                Yearqtr = *(long*) (p + 440);
                Yearmonth = *(long*) (p + 448);
                Yearweek = *(long*) (p + 456);
                Distributor = *(long*) (p + 464);
                StoresInChain = *(long*) (p + 472);
                StoresSelling = *(long*) (p + 480);
                StoresStocking = *(long*) (p + 488);
                UpcCode = Encoding.ASCII.GetString(buffer, 496, 64).TrimEnd();
                UpcType = Encoding.ASCII.GetString(buffer, 560, 64).TrimEnd();
                RawInventory = *(double*) (p + 624);
                RawTotalvalue = *(double*) (p + 632);
                RawUnitssold = *(double*) (p + 640);
                Inventory = *(double*) (p + 648);
                Totalvalue = *(double*) (p + 656);
                Unitssold = *(double*) (p + 664);
                Trans = *(double*) (p + 672);
                ProjInventory = *(double*) (p + 680);
                ProjTotalvalue = *(double*) (p + 688);
                ProjUnitssold = *(double*) (p + 696);
                UnitPrice = *(double*) (p + 704);
                ProjUnitPrice = *(double*) (p + 712);
                UnitsPerPackage = *(double*) (p + 720);
                Outletallocation = *(long*) (p + 728);
                UnitsAdj = *(double*) (p + 736);
                ActuntsAdj = *(double*) (p + 744);
                UpcCodesuppressed = Encoding.ASCII.GetString(buffer, 752, 64).TrimEnd();
                DollarsAdj = *(double*) (p + 816);
                Itemidsuppressed = Encoding.ASCII.GetString(buffer, 824, 64).TrimEnd();
                RactuntsAdj = *(double*) (p + 888);
                UpcCodesuppressednc = Encoding.ASCII.GetString(buffer, 896, 64).TrimEnd();
                Skusuppressednc = Encoding.ASCII.GetString(buffer, 960, 64).TrimEnd();
                RdollarsAdj = *(double*) (p + 1024);
                RetailerItemIdsuppressed = *(long*) (p + 1032);
                RetailerItemIdsuppressednc = *(long*) (p + 1040);
                RunitsAdj = *(double*) (p + 1048);
                Skusuppressed = Encoding.ASCII.GetString(buffer, 1056, 64).TrimEnd();
                Itemidsuppressednc = Encoding.ASCII.GetString(buffer, 1120, 64).TrimEnd();
                ActualUnits = *(double*) (p + 1184);
                ProjActualUnits = *(double*) (p + 1192);
                Numweeks = *(long*) (p + 1200);
                Allbrandfamilysuppressed = *(long*) (p + 1208);
                Allbrandcompanysuppressed = *(long*) (p + 1216);
                Allbrandderivedsuppressed = *(long*) (p + 1224);
                Allbrandsuppressed = *(long*) (p + 1232);
                Retcategorygroupderived = *(long*) (p + 1240);
                Rethidsubcategoryderived = *(long*) (p + 1248);
                Retsubcategoryderived = *(long*) (p + 1256);
                Retsupercategoryderived = *(long*) (p + 1264);
                Wearerderived = *(long*) (p + 1272);
                Allbrandderived = *(long*) (p + 1280);
                Alloutlet = *(long*) (p + 1288);
                Allcategoryderived = *(long*) (p + 1296);
                Allbrandcompany = *(long*) (p + 1304);
                Wearergenderderived = *(long*) (p + 1312);
                Allbrand = *(long*) (p + 1320);
                Alloutletderived = *(long*) (p + 1328);
                Alloutletfamily = *(long*) (p + 1336);
                Allbrandfamily = *(long*) (p + 1344);
                Allindustry = *(long*) (p + 1352);
                Altbusiness = *(long*) (p + 1360);
                Allsubcategoryderived = *(long*) (p + 1368);
                Allsector = *(long*) (p + 1376);
                Retcategoryderived = *(long*) (p + 1384);
                Bbysubclass = *(long*) (p + 1392);
                Bbyvplevel = *(long*) (p + 1400);
                Bbymerchantlevel = *(long*) (p + 1408);
                Bbydepartment = *(long*) (p + 1416);
                Bbyclass = *(long*) (p + 1424);
                Bbybusinessgroup = *(long*) (p + 1432);
                Rid = *(long*) (p + 1440);
                Posoutlet = *(long*) (p + 1448);
                PosId = *(long*) (p + 1456);
                AvgUnitPrice = *(double*) (p + 1464);
                AvgPrjUnitPrice = *(double*) (p + 1472);
                AvgActUnitPrice = *(double*) (p + 1480);
                AvgPrjActUnitPrice = *(double*) (p + 1488);
                AvgPrjActUnitPriceOutlet = *(double*) (p + 1496);
                AvgActUnitPriceOutlet = *(double*) (p + 1504);
                AvgActUnitPriceChannel = *(double*) (p + 1512);
                AvgPrjUnitPriceChannel = *(double*) (p + 1520);
                AvgPrjUnitPriceOutlet = *(double*) (p + 1528);
                AvgPrjActUnitPriceChannel = *(double*) (p + 1536);
                AvgUnitPriceChannel = *(double*) (p + 1544);
                AvgUnitPriceOutlet = *(double*) (p + 1552);
            }
        }
    }
}
