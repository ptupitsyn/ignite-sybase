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
            writer.WriteLong(nameof(Ppweek), Ppweek);
            writer.WriteLong(nameof(Ppmonth), Ppmonth);
            writer.WriteLong(nameof(Country), Country);
            writer.WriteLong(nameof(Itemid), Itemid);
            writer.WriteLong(nameof(Loadid), Loadid);
            writer.WriteLong(nameof(PosId), PosId);
            writer.WriteLong(nameof(Rid), Rid);
            writer.WriteLong(nameof(Posoutlet), Posoutlet);
            writer.WriteString(nameof(Storeid), Storeid);
            writer.WriteString(nameof(Postalcode), Postalcode);
            writer.WriteString(nameof(Outletstoreid), Outletstoreid);
            writer.WriteLong(nameof(RetailerItemId), RetailerItemId);
            writer.WriteString(nameof(Sku), Sku);
            writer.WriteLong(nameof(Itemnumber), Itemnumber);
            writer.WriteLong(nameof(Wearertype), Wearertype);
            writer.WriteLong(nameof(Wearersubtype), Wearersubtype);
            writer.WriteLong(nameof(Wearersize), Wearersize);
            writer.WriteLong(nameof(Retailerregion), Retailerregion);
            writer.WriteLong(nameof(Wearersegment), Wearersegment);
            writer.WriteLong(nameof(Wearergender), Wearergender);
            writer.WriteLong(nameof(Superchannel), Superchannel);
            writer.WriteLong(nameof(Supercategory), Supercategory);
            writer.WriteLong(nameof(Subclass), Subclass);
            writer.WriteLong(nameof(Outletfamily), Outletfamily);
            writer.WriteLong(nameof(Outlet), Outlet);
            writer.WriteLong(nameof(Subchannel), Subchannel);
            writer.WriteLong(nameof(Company), Company);
            writer.WriteLong(nameof(Classification), Classification);
            writer.WriteLong(nameof(Class), Class);
            writer.WriteLong(nameof(Channel), Channel);
            writer.WriteLong(nameof(Categorytype), Categorytype);
            writer.WriteLong(nameof(Category), Category);
            writer.WriteLong(nameof(Brandtype), Brandtype);
            writer.WriteLong(nameof(Brandfamily), Brandfamily);
            writer.WriteLong(nameof(Brand), Brand);
            writer.WriteLong(nameof(Itemnumbersuppressed), Itemnumbersuppressed);
            writer.WriteLong(nameof(Brandfamilysuppressed), Brandfamilysuppressed);
            writer.WriteLong(nameof(BrandfamilysuppressedOrg), BrandfamilysuppressedOrg);
            writer.WriteLong(nameof(Brandfamilysuppressednc), Brandfamilysuppressednc);
            writer.WriteLong(nameof(BrandfamilysuppressedncOrg), BrandfamilysuppressedncOrg);
            writer.WriteLong(nameof(Brandsuppressed), Brandsuppressed);
            writer.WriteLong(nameof(BrandsuppressedOrg), BrandsuppressedOrg);
            writer.WriteLong(nameof(Brandsuppressednc), Brandsuppressednc);
            writer.WriteLong(nameof(BrandsuppressedncOrg), BrandsuppressedncOrg);
            writer.WriteLong(nameof(ItemnumbersuppressedOrg), ItemnumbersuppressedOrg);
            writer.WriteLong(nameof(Brandtypesuppressed), Brandtypesuppressed);
            writer.WriteLong(nameof(BrandtypesuppressedOrg), BrandtypesuppressedOrg);
            writer.WriteLong(nameof(Brandtypesuppressednc), Brandtypesuppressednc);
            writer.WriteLong(nameof(BrandtypesuppressedncOrg), BrandtypesuppressedncOrg);
            writer.WriteLong(nameof(Itemnumbersuppressednc), Itemnumbersuppressednc);
            writer.WriteLong(nameof(ItemnumbersuppressedncOrg), ItemnumbersuppressedncOrg);
            writer.WriteLong(nameof(Introdate), Introdate);
            writer.WriteLong(nameof(Censusregionusa), Censusregionusa);
            writer.WriteLong(nameof(Censusdivisionusa), Censusdivisionusa);
            writer.WriteLong(nameof(State), State);
            writer.WriteLong(nameof(Dma), Dma);
            writer.WriteLong(nameof(Cbsa), Cbsa);
            writer.WriteLong(nameof(Distributor), Distributor);
            writer.WriteLong(nameof(Year), Year);
            writer.WriteLong(nameof(Yearhalf), Yearhalf);
            writer.WriteLong(nameof(Yearqtr), Yearqtr);
            writer.WriteLong(nameof(Yearmonth), Yearmonth);
            writer.WriteLong(nameof(Yearweek), Yearweek);
            writer.WriteDouble(nameof(RawInventory), RawInventory);
            writer.WriteDouble(nameof(RawUnitssold), RawUnitssold);
            writer.WriteDouble(nameof(RawTotalvalue), RawTotalvalue);
            writer.WriteDouble(nameof(Inventory), Inventory);
            writer.WriteDouble(nameof(Unitssold), Unitssold);
            writer.WriteDouble(nameof(Totalvalue), Totalvalue);
            writer.WriteDouble(nameof(Trans), Trans);
            writer.WriteDouble(nameof(ProjInventory), ProjInventory);
            writer.WriteDouble(nameof(ProjUnitssold), ProjUnitssold);
            writer.WriteDouble(nameof(ProjTotalvalue), ProjTotalvalue);
            writer.WriteDouble(nameof(StoresTotalvalue), StoresTotalvalue);
            writer.WriteDouble(nameof(TotindStoresTotalvalue), TotindStoresTotalvalue);
            writer.WriteDouble(nameof(TotindProjStoresTotalvalue), TotindProjStoresTotalvalue);
            writer.WriteDouble(nameof(ProjStoresTotalvalue), ProjStoresTotalvalue);
            writer.WriteDouble(nameof(UnitsPerPackage), UnitsPerPackage);
            writer.WriteDouble(nameof(StoresTotalvalueFactor), StoresTotalvalueFactor);
            writer.WriteDouble(nameof(UnitPrice), UnitPrice);
            writer.WriteDouble(nameof(ProjUnitPrice), ProjUnitPrice);
            writer.WriteString(nameof(UpcCode), UpcCode);
            writer.WriteString(nameof(UpcType), UpcType);
            writer.WriteDouble(nameof(StoreSublvlTotalvalue), StoreSublvlTotalvalue);
            writer.WriteDouble(nameof(PostalSublvlTotalvalue), PostalSublvlTotalvalue);
            writer.WriteString(nameof(Outletpostalcode), Outletpostalcode);
            writer.WriteString(nameof(Skusuppressed), Skusuppressed);
            writer.WriteString(nameof(Itemidsuppressed), Itemidsuppressed);
            writer.WriteLong(nameof(RetailerItemIdsuppressed), RetailerItemIdsuppressed);
            writer.WriteLong(nameof(RetailerItemIdsuppressednc), RetailerItemIdsuppressednc);
            writer.WriteString(nameof(Itemidsuppressednc), Itemidsuppressednc);
            writer.WriteString(nameof(Skusuppressednc), Skusuppressednc);
            writer.WriteString(nameof(UpcCodesuppressednc), UpcCodesuppressednc);
            writer.WriteString(nameof(UpcCodesuppressed), UpcCodesuppressed);
            writer.WriteDouble(nameof(RactuntsAdj), RactuntsAdj);
            writer.WriteDouble(nameof(RunitsAdj), RunitsAdj);
            writer.WriteDouble(nameof(UnitsAdj), UnitsAdj);
            writer.WriteDouble(nameof(RdollarsAdj), RdollarsAdj);
            writer.WriteDouble(nameof(DollarsAdj), DollarsAdj);
            writer.WriteLong(nameof(Outletallocation), Outletallocation);
            writer.WriteDouble(nameof(ActuntsAdj), ActuntsAdj);
            writer.WriteDouble(nameof(ActualUnits), ActualUnits);
            writer.WriteDouble(nameof(ProjActualUnits), ProjActualUnits);
            writer.WriteLong(nameof(Numweeks), Numweeks);
            writer.WriteString(nameof(StoreWeight), StoreWeight);
            writer.WriteDouble(nameof(AvgUnitPrice), AvgUnitPrice);
            writer.WriteDouble(nameof(AvgPrjUnitPrice), AvgPrjUnitPrice);
            writer.WriteDouble(nameof(AvgActUnitPrice), AvgActUnitPrice);
            writer.WriteDouble(nameof(AvgPrjActUnitPrice), AvgPrjActUnitPrice);
            writer.WriteLong(nameof(Allbrandcompanysuppressed), Allbrandcompanysuppressed);
            writer.WriteLong(nameof(Allbrandsuppressed), Allbrandsuppressed);
            writer.WriteLong(nameof(Allbrandfamilysuppressed), Allbrandfamilysuppressed);
            writer.WriteLong(nameof(Allbrandderivedsuppressed), Allbrandderivedsuppressed);
            writer.WriteLong(nameof(Allbrandcompany), Allbrandcompany);
            writer.WriteLong(nameof(Allbrandderived), Allbrandderived);
            writer.WriteLong(nameof(Alloutlet), Alloutlet);
            writer.WriteLong(nameof(Altbusiness), Altbusiness);
            writer.WriteLong(nameof(Alloutletfamily), Alloutletfamily);
            writer.WriteLong(nameof(Retsupercategoryderived), Retsupercategoryderived);
            writer.WriteLong(nameof(Retsubcategoryderived), Retsubcategoryderived);
            writer.WriteLong(nameof(Rethidsubcategoryderived), Rethidsubcategoryderived);
            writer.WriteLong(nameof(Wearerderived), Wearerderived);
            writer.WriteLong(nameof(Allindustry), Allindustry);
            writer.WriteLong(nameof(Wearergenderderived), Wearergenderderived);
            writer.WriteLong(nameof(Allcategoryderived), Allcategoryderived);
            writer.WriteLong(nameof(Allsector), Allsector);
            writer.WriteLong(nameof(Alloutletderived), Alloutletderived);
            writer.WriteLong(nameof(Allbrandfamily), Allbrandfamily);
            writer.WriteLong(nameof(Allbrand), Allbrand);
            writer.WriteLong(nameof(Retcategoryderived), Retcategoryderived);
            writer.WriteLong(nameof(Allsubcategoryderived), Allsubcategoryderived);
            writer.WriteLong(nameof(Retcategorygroupderived), Retcategorygroupderived);
            writer.WriteLong(nameof(Bbysubclass), Bbysubclass);
            writer.WriteLong(nameof(Bbymerchantlevel), Bbymerchantlevel);
            writer.WriteLong(nameof(Bbyvplevel), Bbyvplevel);
            writer.WriteLong(nameof(Bbydepartment), Bbydepartment);
            writer.WriteLong(nameof(Bbyclass), Bbyclass);
            writer.WriteLong(nameof(Bbybusinessgroup), Bbybusinessgroup);
            writer.WriteDouble(nameof(AvgPrjActUnitPriceOutlet), AvgPrjActUnitPriceOutlet);
            writer.WriteDouble(nameof(AvgActUnitPriceChannel), AvgActUnitPriceChannel);
            writer.WriteDouble(nameof(AvgPrjActUnitPriceChannel), AvgPrjActUnitPriceChannel);
            writer.WriteDouble(nameof(AvgUnitPriceOutlet), AvgUnitPriceOutlet);
            writer.WriteDouble(nameof(AvgPrjUnitPriceChannel), AvgPrjUnitPriceChannel);
            writer.WriteDouble(nameof(AvgUnitPriceChannel), AvgUnitPriceChannel);
            writer.WriteDouble(nameof(AvgActUnitPriceOutlet), AvgActUnitPriceOutlet);
            writer.WriteDouble(nameof(AvgPrjUnitPriceOutlet), AvgPrjUnitPriceOutlet);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppweek = reader.ReadLong(nameof(Ppweek));
            Ppmonth = reader.ReadLong(nameof(Ppmonth));
            Country = reader.ReadLong(nameof(Country));
            Itemid = reader.ReadLong(nameof(Itemid));
            Loadid = reader.ReadLong(nameof(Loadid));
            PosId = reader.ReadLong(nameof(PosId));
            Rid = reader.ReadLong(nameof(Rid));
            Posoutlet = reader.ReadLong(nameof(Posoutlet));
            Storeid = reader.ReadString(nameof(Storeid));
            Postalcode = reader.ReadString(nameof(Postalcode));
            Outletstoreid = reader.ReadString(nameof(Outletstoreid));
            RetailerItemId = reader.ReadLong(nameof(RetailerItemId));
            Sku = reader.ReadString(nameof(Sku));
            Itemnumber = reader.ReadLong(nameof(Itemnumber));
            Wearertype = reader.ReadLong(nameof(Wearertype));
            Wearersubtype = reader.ReadLong(nameof(Wearersubtype));
            Wearersize = reader.ReadLong(nameof(Wearersize));
            Retailerregion = reader.ReadLong(nameof(Retailerregion));
            Wearersegment = reader.ReadLong(nameof(Wearersegment));
            Wearergender = reader.ReadLong(nameof(Wearergender));
            Superchannel = reader.ReadLong(nameof(Superchannel));
            Supercategory = reader.ReadLong(nameof(Supercategory));
            Subclass = reader.ReadLong(nameof(Subclass));
            Outletfamily = reader.ReadLong(nameof(Outletfamily));
            Outlet = reader.ReadLong(nameof(Outlet));
            Subchannel = reader.ReadLong(nameof(Subchannel));
            Company = reader.ReadLong(nameof(Company));
            Classification = reader.ReadLong(nameof(Classification));
            Class = reader.ReadLong(nameof(Class));
            Channel = reader.ReadLong(nameof(Channel));
            Categorytype = reader.ReadLong(nameof(Categorytype));
            Category = reader.ReadLong(nameof(Category));
            Brandtype = reader.ReadLong(nameof(Brandtype));
            Brandfamily = reader.ReadLong(nameof(Brandfamily));
            Brand = reader.ReadLong(nameof(Brand));
            Itemnumbersuppressed = reader.ReadLong(nameof(Itemnumbersuppressed));
            Brandfamilysuppressed = reader.ReadLong(nameof(Brandfamilysuppressed));
            BrandfamilysuppressedOrg = reader.ReadLong(nameof(BrandfamilysuppressedOrg));
            Brandfamilysuppressednc = reader.ReadLong(nameof(Brandfamilysuppressednc));
            BrandfamilysuppressedncOrg = reader.ReadLong(nameof(BrandfamilysuppressedncOrg));
            Brandsuppressed = reader.ReadLong(nameof(Brandsuppressed));
            BrandsuppressedOrg = reader.ReadLong(nameof(BrandsuppressedOrg));
            Brandsuppressednc = reader.ReadLong(nameof(Brandsuppressednc));
            BrandsuppressedncOrg = reader.ReadLong(nameof(BrandsuppressedncOrg));
            ItemnumbersuppressedOrg = reader.ReadLong(nameof(ItemnumbersuppressedOrg));
            Brandtypesuppressed = reader.ReadLong(nameof(Brandtypesuppressed));
            BrandtypesuppressedOrg = reader.ReadLong(nameof(BrandtypesuppressedOrg));
            Brandtypesuppressednc = reader.ReadLong(nameof(Brandtypesuppressednc));
            BrandtypesuppressedncOrg = reader.ReadLong(nameof(BrandtypesuppressedncOrg));
            Itemnumbersuppressednc = reader.ReadLong(nameof(Itemnumbersuppressednc));
            ItemnumbersuppressedncOrg = reader.ReadLong(nameof(ItemnumbersuppressedncOrg));
            Introdate = reader.ReadLong(nameof(Introdate));
            Censusregionusa = reader.ReadLong(nameof(Censusregionusa));
            Censusdivisionusa = reader.ReadLong(nameof(Censusdivisionusa));
            State = reader.ReadLong(nameof(State));
            Dma = reader.ReadLong(nameof(Dma));
            Cbsa = reader.ReadLong(nameof(Cbsa));
            Distributor = reader.ReadLong(nameof(Distributor));
            Year = reader.ReadLong(nameof(Year));
            Yearhalf = reader.ReadLong(nameof(Yearhalf));
            Yearqtr = reader.ReadLong(nameof(Yearqtr));
            Yearmonth = reader.ReadLong(nameof(Yearmonth));
            Yearweek = reader.ReadLong(nameof(Yearweek));
            RawInventory = reader.ReadDouble(nameof(RawInventory));
            RawUnitssold = reader.ReadDouble(nameof(RawUnitssold));
            RawTotalvalue = reader.ReadDouble(nameof(RawTotalvalue));
            Inventory = reader.ReadDouble(nameof(Inventory));
            Unitssold = reader.ReadDouble(nameof(Unitssold));
            Totalvalue = reader.ReadDouble(nameof(Totalvalue));
            Trans = reader.ReadDouble(nameof(Trans));
            ProjInventory = reader.ReadDouble(nameof(ProjInventory));
            ProjUnitssold = reader.ReadDouble(nameof(ProjUnitssold));
            ProjTotalvalue = reader.ReadDouble(nameof(ProjTotalvalue));
            StoresTotalvalue = reader.ReadDouble(nameof(StoresTotalvalue));
            TotindStoresTotalvalue = reader.ReadDouble(nameof(TotindStoresTotalvalue));
            TotindProjStoresTotalvalue = reader.ReadDouble(nameof(TotindProjStoresTotalvalue));
            ProjStoresTotalvalue = reader.ReadDouble(nameof(ProjStoresTotalvalue));
            UnitsPerPackage = reader.ReadDouble(nameof(UnitsPerPackage));
            StoresTotalvalueFactor = reader.ReadDouble(nameof(StoresTotalvalueFactor));
            UnitPrice = reader.ReadDouble(nameof(UnitPrice));
            ProjUnitPrice = reader.ReadDouble(nameof(ProjUnitPrice));
            UpcCode = reader.ReadString(nameof(UpcCode));
            UpcType = reader.ReadString(nameof(UpcType));
            StoreSublvlTotalvalue = reader.ReadDouble(nameof(StoreSublvlTotalvalue));
            PostalSublvlTotalvalue = reader.ReadDouble(nameof(PostalSublvlTotalvalue));
            Outletpostalcode = reader.ReadString(nameof(Outletpostalcode));
            Skusuppressed = reader.ReadString(nameof(Skusuppressed));
            Itemidsuppressed = reader.ReadString(nameof(Itemidsuppressed));
            RetailerItemIdsuppressed = reader.ReadLong(nameof(RetailerItemIdsuppressed));
            RetailerItemIdsuppressednc = reader.ReadLong(nameof(RetailerItemIdsuppressednc));
            Itemidsuppressednc = reader.ReadString(nameof(Itemidsuppressednc));
            Skusuppressednc = reader.ReadString(nameof(Skusuppressednc));
            UpcCodesuppressednc = reader.ReadString(nameof(UpcCodesuppressednc));
            UpcCodesuppressed = reader.ReadString(nameof(UpcCodesuppressed));
            RactuntsAdj = reader.ReadDouble(nameof(RactuntsAdj));
            RunitsAdj = reader.ReadDouble(nameof(RunitsAdj));
            UnitsAdj = reader.ReadDouble(nameof(UnitsAdj));
            RdollarsAdj = reader.ReadDouble(nameof(RdollarsAdj));
            DollarsAdj = reader.ReadDouble(nameof(DollarsAdj));
            Outletallocation = reader.ReadLong(nameof(Outletallocation));
            ActuntsAdj = reader.ReadDouble(nameof(ActuntsAdj));
            ActualUnits = reader.ReadDouble(nameof(ActualUnits));
            ProjActualUnits = reader.ReadDouble(nameof(ProjActualUnits));
            Numweeks = reader.ReadLong(nameof(Numweeks));
            StoreWeight = reader.ReadString(nameof(StoreWeight));
            AvgUnitPrice = reader.ReadDouble(nameof(AvgUnitPrice));
            AvgPrjUnitPrice = reader.ReadDouble(nameof(AvgPrjUnitPrice));
            AvgActUnitPrice = reader.ReadDouble(nameof(AvgActUnitPrice));
            AvgPrjActUnitPrice = reader.ReadDouble(nameof(AvgPrjActUnitPrice));
            Allbrandcompanysuppressed = reader.ReadLong(nameof(Allbrandcompanysuppressed));
            Allbrandsuppressed = reader.ReadLong(nameof(Allbrandsuppressed));
            Allbrandfamilysuppressed = reader.ReadLong(nameof(Allbrandfamilysuppressed));
            Allbrandderivedsuppressed = reader.ReadLong(nameof(Allbrandderivedsuppressed));
            Allbrandcompany = reader.ReadLong(nameof(Allbrandcompany));
            Allbrandderived = reader.ReadLong(nameof(Allbrandderived));
            Alloutlet = reader.ReadLong(nameof(Alloutlet));
            Altbusiness = reader.ReadLong(nameof(Altbusiness));
            Alloutletfamily = reader.ReadLong(nameof(Alloutletfamily));
            Retsupercategoryderived = reader.ReadLong(nameof(Retsupercategoryderived));
            Retsubcategoryderived = reader.ReadLong(nameof(Retsubcategoryderived));
            Rethidsubcategoryderived = reader.ReadLong(nameof(Rethidsubcategoryderived));
            Wearerderived = reader.ReadLong(nameof(Wearerderived));
            Allindustry = reader.ReadLong(nameof(Allindustry));
            Wearergenderderived = reader.ReadLong(nameof(Wearergenderderived));
            Allcategoryderived = reader.ReadLong(nameof(Allcategoryderived));
            Allsector = reader.ReadLong(nameof(Allsector));
            Alloutletderived = reader.ReadLong(nameof(Alloutletderived));
            Allbrandfamily = reader.ReadLong(nameof(Allbrandfamily));
            Allbrand = reader.ReadLong(nameof(Allbrand));
            Retcategoryderived = reader.ReadLong(nameof(Retcategoryderived));
            Allsubcategoryderived = reader.ReadLong(nameof(Allsubcategoryderived));
            Retcategorygroupderived = reader.ReadLong(nameof(Retcategorygroupderived));
            Bbysubclass = reader.ReadLong(nameof(Bbysubclass));
            Bbymerchantlevel = reader.ReadLong(nameof(Bbymerchantlevel));
            Bbyvplevel = reader.ReadLong(nameof(Bbyvplevel));
            Bbydepartment = reader.ReadLong(nameof(Bbydepartment));
            Bbyclass = reader.ReadLong(nameof(Bbyclass));
            Bbybusinessgroup = reader.ReadLong(nameof(Bbybusinessgroup));
            AvgPrjActUnitPriceOutlet = reader.ReadDouble(nameof(AvgPrjActUnitPriceOutlet));
            AvgActUnitPriceChannel = reader.ReadDouble(nameof(AvgActUnitPriceChannel));
            AvgPrjActUnitPriceChannel = reader.ReadDouble(nameof(AvgPrjActUnitPriceChannel));
            AvgUnitPriceOutlet = reader.ReadDouble(nameof(AvgUnitPriceOutlet));
            AvgPrjUnitPriceChannel = reader.ReadDouble(nameof(AvgPrjUnitPriceChannel));
            AvgUnitPriceChannel = reader.ReadDouble(nameof(AvgUnitPriceChannel));
            AvgActUnitPriceOutlet = reader.ReadDouble(nameof(AvgActUnitPriceOutlet));
            AvgPrjUnitPriceOutlet = reader.ReadDouble(nameof(AvgPrjUnitPriceOutlet));
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
