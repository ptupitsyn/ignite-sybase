// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class FactPosdata : IBinarizable, ICanReadFromRecordBuffer
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
            writer.WriteLong(nameof(Ppmonth), Ppmonth);
            writer.WriteLong(nameof(Ppweek), Ppweek);
            writer.WriteLong(nameof(Country), Country);
            writer.WriteLong(nameof(Itemid), Itemid);
            writer.WriteLong(nameof(Loadid), Loadid);
            writer.WriteLong(nameof(RetailerItemId), RetailerItemId);
            writer.WriteString(nameof(Sku), Sku);
            writer.WriteLong(nameof(Itemnumber), Itemnumber);
            writer.WriteLong(nameof(Company), Company);
            writer.WriteLong(nameof(Classification), Classification);
            writer.WriteLong(nameof(Class), Class);
            writer.WriteLong(nameof(Channel), Channel);
            writer.WriteLong(nameof(Categorytype), Categorytype);
            writer.WriteLong(nameof(Superchannel), Superchannel);
            writer.WriteLong(nameof(Supercategory), Supercategory);
            writer.WriteLong(nameof(Subclass), Subclass);
            writer.WriteLong(nameof(Subchannel), Subchannel);
            writer.WriteLong(nameof(Category), Category);
            writer.WriteLong(nameof(Brandtype), Brandtype);
            writer.WriteLong(nameof(Brandfamily), Brandfamily);
            writer.WriteLong(nameof(Wearertype), Wearertype);
            writer.WriteLong(nameof(Retailerregion), Retailerregion);
            writer.WriteLong(nameof(Wearersubtype), Wearersubtype);
            writer.WriteLong(nameof(Brand), Brand);
            writer.WriteLong(nameof(Wearersize), Wearersize);
            writer.WriteLong(nameof(Outlet), Outlet);
            writer.WriteLong(nameof(Outletfamily), Outletfamily);
            writer.WriteLong(nameof(Wearersegment), Wearersegment);
            writer.WriteLong(nameof(Wearergender), Wearergender);
            writer.WriteLong(nameof(Introdate), Introdate);
            writer.WriteLong(nameof(ItemnumbersuppressedncOrg), ItemnumbersuppressedncOrg);
            writer.WriteLong(nameof(ItemnumbersuppressedOrg), ItemnumbersuppressedOrg);
            writer.WriteLong(nameof(Itemnumbersuppressed), Itemnumbersuppressed);
            writer.WriteLong(nameof(Brandfamilysuppressed), Brandfamilysuppressed);
            writer.WriteLong(nameof(BrandfamilysuppressedOrg), BrandfamilysuppressedOrg);
            writer.WriteLong(nameof(Brandfamilysuppressednc), Brandfamilysuppressednc);
            writer.WriteLong(nameof(BrandfamilysuppressedncOrg), BrandfamilysuppressedncOrg);
            writer.WriteLong(nameof(Brandsuppressed), Brandsuppressed);
            writer.WriteLong(nameof(BrandsuppressedOrg), BrandsuppressedOrg);
            writer.WriteLong(nameof(Brandsuppressednc), Brandsuppressednc);
            writer.WriteLong(nameof(BrandsuppressedncOrg), BrandsuppressedncOrg);
            writer.WriteLong(nameof(Itemnumbersuppressednc), Itemnumbersuppressednc);
            writer.WriteLong(nameof(Brandtypesuppressed), Brandtypesuppressed);
            writer.WriteLong(nameof(BrandtypesuppressedOrg), BrandtypesuppressedOrg);
            writer.WriteLong(nameof(Brandtypesuppressednc), Brandtypesuppressednc);
            writer.WriteLong(nameof(BrandtypesuppressedncOrg), BrandtypesuppressedncOrg);
            writer.WriteLong(nameof(Year), Year);
            writer.WriteLong(nameof(Yearhalf), Yearhalf);
            writer.WriteLong(nameof(Yearqtr), Yearqtr);
            writer.WriteLong(nameof(Yearmonth), Yearmonth);
            writer.WriteLong(nameof(Yearweek), Yearweek);
            writer.WriteLong(nameof(Distributor), Distributor);
            writer.WriteLong(nameof(StoresInChain), StoresInChain);
            writer.WriteLong(nameof(StoresSelling), StoresSelling);
            writer.WriteLong(nameof(StoresStocking), StoresStocking);
            writer.WriteString(nameof(UpcCode), UpcCode);
            writer.WriteString(nameof(UpcType), UpcType);
            writer.WriteDouble(nameof(RawInventory), RawInventory);
            writer.WriteDouble(nameof(RawTotalvalue), RawTotalvalue);
            writer.WriteDouble(nameof(RawUnitssold), RawUnitssold);
            writer.WriteDouble(nameof(Inventory), Inventory);
            writer.WriteDouble(nameof(Totalvalue), Totalvalue);
            writer.WriteDouble(nameof(Unitssold), Unitssold);
            writer.WriteDouble(nameof(Trans), Trans);
            writer.WriteDouble(nameof(ProjInventory), ProjInventory);
            writer.WriteDouble(nameof(ProjTotalvalue), ProjTotalvalue);
            writer.WriteDouble(nameof(ProjUnitssold), ProjUnitssold);
            writer.WriteDouble(nameof(UnitPrice), UnitPrice);
            writer.WriteDouble(nameof(ProjUnitPrice), ProjUnitPrice);
            writer.WriteDouble(nameof(UnitsPerPackage), UnitsPerPackage);
            writer.WriteLong(nameof(Outletallocation), Outletallocation);
            writer.WriteDouble(nameof(UnitsAdj), UnitsAdj);
            writer.WriteDouble(nameof(ActuntsAdj), ActuntsAdj);
            writer.WriteString(nameof(UpcCodesuppressed), UpcCodesuppressed);
            writer.WriteDouble(nameof(DollarsAdj), DollarsAdj);
            writer.WriteString(nameof(Itemidsuppressed), Itemidsuppressed);
            writer.WriteDouble(nameof(RactuntsAdj), RactuntsAdj);
            writer.WriteString(nameof(UpcCodesuppressednc), UpcCodesuppressednc);
            writer.WriteString(nameof(Skusuppressednc), Skusuppressednc);
            writer.WriteDouble(nameof(RdollarsAdj), RdollarsAdj);
            writer.WriteLong(nameof(RetailerItemIdsuppressed), RetailerItemIdsuppressed);
            writer.WriteLong(nameof(RetailerItemIdsuppressednc), RetailerItemIdsuppressednc);
            writer.WriteDouble(nameof(RunitsAdj), RunitsAdj);
            writer.WriteString(nameof(Skusuppressed), Skusuppressed);
            writer.WriteString(nameof(Itemidsuppressednc), Itemidsuppressednc);
            writer.WriteDouble(nameof(ActualUnits), ActualUnits);
            writer.WriteDouble(nameof(ProjActualUnits), ProjActualUnits);
            writer.WriteLong(nameof(Numweeks), Numweeks);
            writer.WriteLong(nameof(Allbrandfamilysuppressed), Allbrandfamilysuppressed);
            writer.WriteLong(nameof(Allbrandcompanysuppressed), Allbrandcompanysuppressed);
            writer.WriteLong(nameof(Allbrandderivedsuppressed), Allbrandderivedsuppressed);
            writer.WriteLong(nameof(Allbrandsuppressed), Allbrandsuppressed);
            writer.WriteLong(nameof(Retcategorygroupderived), Retcategorygroupderived);
            writer.WriteLong(nameof(Rethidsubcategoryderived), Rethidsubcategoryderived);
            writer.WriteLong(nameof(Retsubcategoryderived), Retsubcategoryderived);
            writer.WriteLong(nameof(Retsupercategoryderived), Retsupercategoryderived);
            writer.WriteLong(nameof(Wearerderived), Wearerderived);
            writer.WriteLong(nameof(Allbrandderived), Allbrandderived);
            writer.WriteLong(nameof(Alloutlet), Alloutlet);
            writer.WriteLong(nameof(Allcategoryderived), Allcategoryderived);
            writer.WriteLong(nameof(Allbrandcompany), Allbrandcompany);
            writer.WriteLong(nameof(Wearergenderderived), Wearergenderderived);
            writer.WriteLong(nameof(Allbrand), Allbrand);
            writer.WriteLong(nameof(Alloutletderived), Alloutletderived);
            writer.WriteLong(nameof(Alloutletfamily), Alloutletfamily);
            writer.WriteLong(nameof(Allbrandfamily), Allbrandfamily);
            writer.WriteLong(nameof(Allindustry), Allindustry);
            writer.WriteLong(nameof(Altbusiness), Altbusiness);
            writer.WriteLong(nameof(Allsubcategoryderived), Allsubcategoryderived);
            writer.WriteLong(nameof(Allsector), Allsector);
            writer.WriteLong(nameof(Retcategoryderived), Retcategoryderived);
            writer.WriteLong(nameof(Bbysubclass), Bbysubclass);
            writer.WriteLong(nameof(Bbyvplevel), Bbyvplevel);
            writer.WriteLong(nameof(Bbymerchantlevel), Bbymerchantlevel);
            writer.WriteLong(nameof(Bbydepartment), Bbydepartment);
            writer.WriteLong(nameof(Bbyclass), Bbyclass);
            writer.WriteLong(nameof(Bbybusinessgroup), Bbybusinessgroup);
            writer.WriteLong(nameof(Rid), Rid);
            writer.WriteLong(nameof(Posoutlet), Posoutlet);
            writer.WriteLong(nameof(PosId), PosId);
            writer.WriteDouble(nameof(AvgUnitPrice), AvgUnitPrice);
            writer.WriteDouble(nameof(AvgPrjUnitPrice), AvgPrjUnitPrice);
            writer.WriteDouble(nameof(AvgActUnitPrice), AvgActUnitPrice);
            writer.WriteDouble(nameof(AvgPrjActUnitPrice), AvgPrjActUnitPrice);
            writer.WriteDouble(nameof(AvgPrjActUnitPriceOutlet), AvgPrjActUnitPriceOutlet);
            writer.WriteDouble(nameof(AvgActUnitPriceOutlet), AvgActUnitPriceOutlet);
            writer.WriteDouble(nameof(AvgActUnitPriceChannel), AvgActUnitPriceChannel);
            writer.WriteDouble(nameof(AvgPrjUnitPriceChannel), AvgPrjUnitPriceChannel);
            writer.WriteDouble(nameof(AvgPrjUnitPriceOutlet), AvgPrjUnitPriceOutlet);
            writer.WriteDouble(nameof(AvgPrjActUnitPriceChannel), AvgPrjActUnitPriceChannel);
            writer.WriteDouble(nameof(AvgUnitPriceChannel), AvgUnitPriceChannel);
            writer.WriteDouble(nameof(AvgUnitPriceOutlet), AvgUnitPriceOutlet);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppmonth = reader.ReadLong(nameof(Ppmonth));
            Ppweek = reader.ReadLong(nameof(Ppweek));
            Country = reader.ReadLong(nameof(Country));
            Itemid = reader.ReadLong(nameof(Itemid));
            Loadid = reader.ReadLong(nameof(Loadid));
            RetailerItemId = reader.ReadLong(nameof(RetailerItemId));
            Sku = reader.ReadString(nameof(Sku));
            Itemnumber = reader.ReadLong(nameof(Itemnumber));
            Company = reader.ReadLong(nameof(Company));
            Classification = reader.ReadLong(nameof(Classification));
            Class = reader.ReadLong(nameof(Class));
            Channel = reader.ReadLong(nameof(Channel));
            Categorytype = reader.ReadLong(nameof(Categorytype));
            Superchannel = reader.ReadLong(nameof(Superchannel));
            Supercategory = reader.ReadLong(nameof(Supercategory));
            Subclass = reader.ReadLong(nameof(Subclass));
            Subchannel = reader.ReadLong(nameof(Subchannel));
            Category = reader.ReadLong(nameof(Category));
            Brandtype = reader.ReadLong(nameof(Brandtype));
            Brandfamily = reader.ReadLong(nameof(Brandfamily));
            Wearertype = reader.ReadLong(nameof(Wearertype));
            Retailerregion = reader.ReadLong(nameof(Retailerregion));
            Wearersubtype = reader.ReadLong(nameof(Wearersubtype));
            Brand = reader.ReadLong(nameof(Brand));
            Wearersize = reader.ReadLong(nameof(Wearersize));
            Outlet = reader.ReadLong(nameof(Outlet));
            Outletfamily = reader.ReadLong(nameof(Outletfamily));
            Wearersegment = reader.ReadLong(nameof(Wearersegment));
            Wearergender = reader.ReadLong(nameof(Wearergender));
            Introdate = reader.ReadLong(nameof(Introdate));
            ItemnumbersuppressedncOrg = reader.ReadLong(nameof(ItemnumbersuppressedncOrg));
            ItemnumbersuppressedOrg = reader.ReadLong(nameof(ItemnumbersuppressedOrg));
            Itemnumbersuppressed = reader.ReadLong(nameof(Itemnumbersuppressed));
            Brandfamilysuppressed = reader.ReadLong(nameof(Brandfamilysuppressed));
            BrandfamilysuppressedOrg = reader.ReadLong(nameof(BrandfamilysuppressedOrg));
            Brandfamilysuppressednc = reader.ReadLong(nameof(Brandfamilysuppressednc));
            BrandfamilysuppressedncOrg = reader.ReadLong(nameof(BrandfamilysuppressedncOrg));
            Brandsuppressed = reader.ReadLong(nameof(Brandsuppressed));
            BrandsuppressedOrg = reader.ReadLong(nameof(BrandsuppressedOrg));
            Brandsuppressednc = reader.ReadLong(nameof(Brandsuppressednc));
            BrandsuppressedncOrg = reader.ReadLong(nameof(BrandsuppressedncOrg));
            Itemnumbersuppressednc = reader.ReadLong(nameof(Itemnumbersuppressednc));
            Brandtypesuppressed = reader.ReadLong(nameof(Brandtypesuppressed));
            BrandtypesuppressedOrg = reader.ReadLong(nameof(BrandtypesuppressedOrg));
            Brandtypesuppressednc = reader.ReadLong(nameof(Brandtypesuppressednc));
            BrandtypesuppressedncOrg = reader.ReadLong(nameof(BrandtypesuppressedncOrg));
            Year = reader.ReadLong(nameof(Year));
            Yearhalf = reader.ReadLong(nameof(Yearhalf));
            Yearqtr = reader.ReadLong(nameof(Yearqtr));
            Yearmonth = reader.ReadLong(nameof(Yearmonth));
            Yearweek = reader.ReadLong(nameof(Yearweek));
            Distributor = reader.ReadLong(nameof(Distributor));
            StoresInChain = reader.ReadLong(nameof(StoresInChain));
            StoresSelling = reader.ReadLong(nameof(StoresSelling));
            StoresStocking = reader.ReadLong(nameof(StoresStocking));
            UpcCode = reader.ReadString(nameof(UpcCode));
            UpcType = reader.ReadString(nameof(UpcType));
            RawInventory = reader.ReadDouble(nameof(RawInventory));
            RawTotalvalue = reader.ReadDouble(nameof(RawTotalvalue));
            RawUnitssold = reader.ReadDouble(nameof(RawUnitssold));
            Inventory = reader.ReadDouble(nameof(Inventory));
            Totalvalue = reader.ReadDouble(nameof(Totalvalue));
            Unitssold = reader.ReadDouble(nameof(Unitssold));
            Trans = reader.ReadDouble(nameof(Trans));
            ProjInventory = reader.ReadDouble(nameof(ProjInventory));
            ProjTotalvalue = reader.ReadDouble(nameof(ProjTotalvalue));
            ProjUnitssold = reader.ReadDouble(nameof(ProjUnitssold));
            UnitPrice = reader.ReadDouble(nameof(UnitPrice));
            ProjUnitPrice = reader.ReadDouble(nameof(ProjUnitPrice));
            UnitsPerPackage = reader.ReadDouble(nameof(UnitsPerPackage));
            Outletallocation = reader.ReadLong(nameof(Outletallocation));
            UnitsAdj = reader.ReadDouble(nameof(UnitsAdj));
            ActuntsAdj = reader.ReadDouble(nameof(ActuntsAdj));
            UpcCodesuppressed = reader.ReadString(nameof(UpcCodesuppressed));
            DollarsAdj = reader.ReadDouble(nameof(DollarsAdj));
            Itemidsuppressed = reader.ReadString(nameof(Itemidsuppressed));
            RactuntsAdj = reader.ReadDouble(nameof(RactuntsAdj));
            UpcCodesuppressednc = reader.ReadString(nameof(UpcCodesuppressednc));
            Skusuppressednc = reader.ReadString(nameof(Skusuppressednc));
            RdollarsAdj = reader.ReadDouble(nameof(RdollarsAdj));
            RetailerItemIdsuppressed = reader.ReadLong(nameof(RetailerItemIdsuppressed));
            RetailerItemIdsuppressednc = reader.ReadLong(nameof(RetailerItemIdsuppressednc));
            RunitsAdj = reader.ReadDouble(nameof(RunitsAdj));
            Skusuppressed = reader.ReadString(nameof(Skusuppressed));
            Itemidsuppressednc = reader.ReadString(nameof(Itemidsuppressednc));
            ActualUnits = reader.ReadDouble(nameof(ActualUnits));
            ProjActualUnits = reader.ReadDouble(nameof(ProjActualUnits));
            Numweeks = reader.ReadLong(nameof(Numweeks));
            Allbrandfamilysuppressed = reader.ReadLong(nameof(Allbrandfamilysuppressed));
            Allbrandcompanysuppressed = reader.ReadLong(nameof(Allbrandcompanysuppressed));
            Allbrandderivedsuppressed = reader.ReadLong(nameof(Allbrandderivedsuppressed));
            Allbrandsuppressed = reader.ReadLong(nameof(Allbrandsuppressed));
            Retcategorygroupderived = reader.ReadLong(nameof(Retcategorygroupderived));
            Rethidsubcategoryderived = reader.ReadLong(nameof(Rethidsubcategoryderived));
            Retsubcategoryderived = reader.ReadLong(nameof(Retsubcategoryderived));
            Retsupercategoryderived = reader.ReadLong(nameof(Retsupercategoryderived));
            Wearerderived = reader.ReadLong(nameof(Wearerderived));
            Allbrandderived = reader.ReadLong(nameof(Allbrandderived));
            Alloutlet = reader.ReadLong(nameof(Alloutlet));
            Allcategoryderived = reader.ReadLong(nameof(Allcategoryderived));
            Allbrandcompany = reader.ReadLong(nameof(Allbrandcompany));
            Wearergenderderived = reader.ReadLong(nameof(Wearergenderderived));
            Allbrand = reader.ReadLong(nameof(Allbrand));
            Alloutletderived = reader.ReadLong(nameof(Alloutletderived));
            Alloutletfamily = reader.ReadLong(nameof(Alloutletfamily));
            Allbrandfamily = reader.ReadLong(nameof(Allbrandfamily));
            Allindustry = reader.ReadLong(nameof(Allindustry));
            Altbusiness = reader.ReadLong(nameof(Altbusiness));
            Allsubcategoryderived = reader.ReadLong(nameof(Allsubcategoryderived));
            Allsector = reader.ReadLong(nameof(Allsector));
            Retcategoryderived = reader.ReadLong(nameof(Retcategoryderived));
            Bbysubclass = reader.ReadLong(nameof(Bbysubclass));
            Bbyvplevel = reader.ReadLong(nameof(Bbyvplevel));
            Bbymerchantlevel = reader.ReadLong(nameof(Bbymerchantlevel));
            Bbydepartment = reader.ReadLong(nameof(Bbydepartment));
            Bbyclass = reader.ReadLong(nameof(Bbyclass));
            Bbybusinessgroup = reader.ReadLong(nameof(Bbybusinessgroup));
            Rid = reader.ReadLong(nameof(Rid));
            Posoutlet = reader.ReadLong(nameof(Posoutlet));
            PosId = reader.ReadLong(nameof(PosId));
            AvgUnitPrice = reader.ReadDouble(nameof(AvgUnitPrice));
            AvgPrjUnitPrice = reader.ReadDouble(nameof(AvgPrjUnitPrice));
            AvgActUnitPrice = reader.ReadDouble(nameof(AvgActUnitPrice));
            AvgPrjActUnitPrice = reader.ReadDouble(nameof(AvgPrjActUnitPrice));
            AvgPrjActUnitPriceOutlet = reader.ReadDouble(nameof(AvgPrjActUnitPriceOutlet));
            AvgActUnitPriceOutlet = reader.ReadDouble(nameof(AvgActUnitPriceOutlet));
            AvgActUnitPriceChannel = reader.ReadDouble(nameof(AvgActUnitPriceChannel));
            AvgPrjUnitPriceChannel = reader.ReadDouble(nameof(AvgPrjUnitPriceChannel));
            AvgPrjUnitPriceOutlet = reader.ReadDouble(nameof(AvgPrjUnitPriceOutlet));
            AvgPrjActUnitPriceChannel = reader.ReadDouble(nameof(AvgPrjActUnitPriceChannel));
            AvgUnitPriceChannel = reader.ReadDouble(nameof(AvgUnitPriceChannel));
            AvgUnitPriceOutlet = reader.ReadDouble(nameof(AvgUnitPriceOutlet));
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
