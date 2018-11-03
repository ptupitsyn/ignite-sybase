// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AggrDataBrand : IBinarizable, ICanReadFromRecordBuffer
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
            writer.WriteLong(nameof(Ppmonth), Ppmonth);
            writer.WriteLong(nameof(Ppweek), Ppweek);
            writer.WriteLong(nameof(Distributor), Distributor);
            writer.WriteLong(nameof(Posoutlet), Posoutlet);
            writer.WriteString(nameof(Storeid), Storeid);
            writer.WriteString(nameof(Postalcode), Postalcode);
            writer.WriteString(nameof(Outletstoreid), Outletstoreid);
            writer.WriteLong(nameof(Loadid), Loadid);
            writer.WriteLong(nameof(Dma), Dma);
            writer.WriteLong(nameof(Year), Year);
            writer.WriteLong(nameof(Yearhalf), Yearhalf);
            writer.WriteLong(nameof(Yearqtr), Yearqtr);
            writer.WriteLong(nameof(Yearmonth), Yearmonth);
            writer.WriteLong(nameof(Yearweek), Yearweek);
            writer.WriteLong(nameof(Supercategory), Supercategory);
            writer.WriteLong(nameof(Subclass), Subclass);
            writer.WriteLong(nameof(Category), Category);
            writer.WriteLong(nameof(Categorytype), Categorytype);
            writer.WriteLong(nameof(Brand), Brand);
            writer.WriteLong(nameof(Brandfamily), Brandfamily);
            writer.WriteLong(nameof(Channel), Channel);
            writer.WriteLong(nameof(Class), Class);
            writer.WriteLong(nameof(Classification), Classification);
            writer.WriteLong(nameof(Company), Company);
            writer.WriteLong(nameof(Wearertype), Wearertype);
            writer.WriteLong(nameof(Wearersubtype), Wearersubtype);
            writer.WriteLong(nameof(Subchannel), Subchannel);
            writer.WriteLong(nameof(Wearersize), Wearersize);
            writer.WriteLong(nameof(Wearersegment), Wearersegment);
            writer.WriteLong(nameof(Outlet), Outlet);
            writer.WriteLong(nameof(Brandtype), Brandtype);
            writer.WriteLong(nameof(Outletfamily), Outletfamily);
            writer.WriteLong(nameof(Retailerregion), Retailerregion);
            writer.WriteLong(nameof(Wearergender), Wearergender);
            writer.WriteLong(nameof(Superchannel), Superchannel);
            writer.WriteLong(nameof(State), State);
            writer.WriteLong(nameof(Censusregionusa), Censusregionusa);
            writer.WriteLong(nameof(Censusdivisionusa), Censusdivisionusa);
            writer.WriteDouble(nameof(Inventory), Inventory);
            writer.WriteDouble(nameof(Unitssold), Unitssold);
            writer.WriteDouble(nameof(Totalvalue), Totalvalue);
            writer.WriteDouble(nameof(Trans), Trans);
            writer.WriteDouble(nameof(ProjInventory), ProjInventory);
            writer.WriteDouble(nameof(ProjUnitssold), ProjUnitssold);
            writer.WriteDouble(nameof(ProjTotalvalue), ProjTotalvalue);
            writer.WriteDouble(nameof(TotindStoresTotalvalue), TotindStoresTotalvalue);
            writer.WriteDouble(nameof(StoresTotalvalue), StoresTotalvalue);
            writer.WriteString(nameof(StoreWeight), StoreWeight);
            writer.WriteLong(nameof(BrandfamilysuppressedncOrg), BrandfamilysuppressedncOrg);
            writer.WriteLong(nameof(BrandtypesuppressedOrg), BrandtypesuppressedOrg);
            writer.WriteLong(nameof(Brandfamilysuppressed), Brandfamilysuppressed);
            writer.WriteLong(nameof(BrandsuppressedncOrg), BrandsuppressedncOrg);
            writer.WriteLong(nameof(Brandsuppressed), Brandsuppressed);
            writer.WriteLong(nameof(BrandsuppressedOrg), BrandsuppressedOrg);
            writer.WriteLong(nameof(BrandtypesuppressedncOrg), BrandtypesuppressedncOrg);
            writer.WriteLong(nameof(Brandtypesuppressednc), Brandtypesuppressednc);
            writer.WriteDouble(nameof(ProjStoresTotalvalue), ProjStoresTotalvalue);
            writer.WriteDouble(nameof(TotindProjStoresTotalvalue), TotindProjStoresTotalvalue);
            writer.WriteLong(nameof(BrandfamilysuppressedOrg), BrandfamilysuppressedOrg);
            writer.WriteLong(nameof(Brandtypesuppressed), Brandtypesuppressed);
            writer.WriteLong(nameof(Brandsuppressednc), Brandsuppressednc);
            writer.WriteLong(nameof(Brandfamilysuppressednc), Brandfamilysuppressednc);
            writer.WriteDouble(nameof(ProjUnitPrice), ProjUnitPrice);
            writer.WriteDouble(nameof(StoreSublvlTotalvalue), StoreSublvlTotalvalue);
            writer.WriteDouble(nameof(PostalSublvlTotalvalue), PostalSublvlTotalvalue);
            writer.WriteLong(nameof(Outletallocation), Outletallocation);
            writer.WriteString(nameof(Outletpostalcode), Outletpostalcode);
            writer.WriteDouble(nameof(ActualUnits), ActualUnits);
            writer.WriteDouble(nameof(ProjActualUnits), ProjActualUnits);
            writer.WriteLong(nameof(Numweeks), Numweeks);
            writer.WriteDouble(nameof(RdollarsAdj), RdollarsAdj);
            writer.WriteDouble(nameof(DollarsAdj), DollarsAdj);
            writer.WriteDouble(nameof(UnitsAdj), UnitsAdj);
            writer.WriteDouble(nameof(RunitsAdj), RunitsAdj);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppmonth = reader.ReadLong(nameof(Ppmonth));
            Ppweek = reader.ReadLong(nameof(Ppweek));
            Distributor = reader.ReadLong(nameof(Distributor));
            Posoutlet = reader.ReadLong(nameof(Posoutlet));
            Storeid = reader.ReadString(nameof(Storeid));
            Postalcode = reader.ReadString(nameof(Postalcode));
            Outletstoreid = reader.ReadString(nameof(Outletstoreid));
            Loadid = reader.ReadLong(nameof(Loadid));
            Dma = reader.ReadLong(nameof(Dma));
            Year = reader.ReadLong(nameof(Year));
            Yearhalf = reader.ReadLong(nameof(Yearhalf));
            Yearqtr = reader.ReadLong(nameof(Yearqtr));
            Yearmonth = reader.ReadLong(nameof(Yearmonth));
            Yearweek = reader.ReadLong(nameof(Yearweek));
            Supercategory = reader.ReadLong(nameof(Supercategory));
            Subclass = reader.ReadLong(nameof(Subclass));
            Category = reader.ReadLong(nameof(Category));
            Categorytype = reader.ReadLong(nameof(Categorytype));
            Brand = reader.ReadLong(nameof(Brand));
            Brandfamily = reader.ReadLong(nameof(Brandfamily));
            Channel = reader.ReadLong(nameof(Channel));
            Class = reader.ReadLong(nameof(Class));
            Classification = reader.ReadLong(nameof(Classification));
            Company = reader.ReadLong(nameof(Company));
            Wearertype = reader.ReadLong(nameof(Wearertype));
            Wearersubtype = reader.ReadLong(nameof(Wearersubtype));
            Subchannel = reader.ReadLong(nameof(Subchannel));
            Wearersize = reader.ReadLong(nameof(Wearersize));
            Wearersegment = reader.ReadLong(nameof(Wearersegment));
            Outlet = reader.ReadLong(nameof(Outlet));
            Brandtype = reader.ReadLong(nameof(Brandtype));
            Outletfamily = reader.ReadLong(nameof(Outletfamily));
            Retailerregion = reader.ReadLong(nameof(Retailerregion));
            Wearergender = reader.ReadLong(nameof(Wearergender));
            Superchannel = reader.ReadLong(nameof(Superchannel));
            State = reader.ReadLong(nameof(State));
            Censusregionusa = reader.ReadLong(nameof(Censusregionusa));
            Censusdivisionusa = reader.ReadLong(nameof(Censusdivisionusa));
            Inventory = reader.ReadDouble(nameof(Inventory));
            Unitssold = reader.ReadDouble(nameof(Unitssold));
            Totalvalue = reader.ReadDouble(nameof(Totalvalue));
            Trans = reader.ReadDouble(nameof(Trans));
            ProjInventory = reader.ReadDouble(nameof(ProjInventory));
            ProjUnitssold = reader.ReadDouble(nameof(ProjUnitssold));
            ProjTotalvalue = reader.ReadDouble(nameof(ProjTotalvalue));
            TotindStoresTotalvalue = reader.ReadDouble(nameof(TotindStoresTotalvalue));
            StoresTotalvalue = reader.ReadDouble(nameof(StoresTotalvalue));
            StoreWeight = reader.ReadString(nameof(StoreWeight));
            BrandfamilysuppressedncOrg = reader.ReadLong(nameof(BrandfamilysuppressedncOrg));
            BrandtypesuppressedOrg = reader.ReadLong(nameof(BrandtypesuppressedOrg));
            Brandfamilysuppressed = reader.ReadLong(nameof(Brandfamilysuppressed));
            BrandsuppressedncOrg = reader.ReadLong(nameof(BrandsuppressedncOrg));
            Brandsuppressed = reader.ReadLong(nameof(Brandsuppressed));
            BrandsuppressedOrg = reader.ReadLong(nameof(BrandsuppressedOrg));
            BrandtypesuppressedncOrg = reader.ReadLong(nameof(BrandtypesuppressedncOrg));
            Brandtypesuppressednc = reader.ReadLong(nameof(Brandtypesuppressednc));
            ProjStoresTotalvalue = reader.ReadDouble(nameof(ProjStoresTotalvalue));
            TotindProjStoresTotalvalue = reader.ReadDouble(nameof(TotindProjStoresTotalvalue));
            BrandfamilysuppressedOrg = reader.ReadLong(nameof(BrandfamilysuppressedOrg));
            Brandtypesuppressed = reader.ReadLong(nameof(Brandtypesuppressed));
            Brandsuppressednc = reader.ReadLong(nameof(Brandsuppressednc));
            Brandfamilysuppressednc = reader.ReadLong(nameof(Brandfamilysuppressednc));
            ProjUnitPrice = reader.ReadDouble(nameof(ProjUnitPrice));
            StoreSublvlTotalvalue = reader.ReadDouble(nameof(StoreSublvlTotalvalue));
            PostalSublvlTotalvalue = reader.ReadDouble(nameof(PostalSublvlTotalvalue));
            Outletallocation = reader.ReadLong(nameof(Outletallocation));
            Outletpostalcode = reader.ReadString(nameof(Outletpostalcode));
            ActualUnits = reader.ReadDouble(nameof(ActualUnits));
            ProjActualUnits = reader.ReadDouble(nameof(ProjActualUnits));
            Numweeks = reader.ReadLong(nameof(Numweeks));
            RdollarsAdj = reader.ReadDouble(nameof(RdollarsAdj));
            DollarsAdj = reader.ReadDouble(nameof(DollarsAdj));
            UnitsAdj = reader.ReadDouble(nameof(UnitsAdj));
            RunitsAdj = reader.ReadDouble(nameof(RunitsAdj));
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
