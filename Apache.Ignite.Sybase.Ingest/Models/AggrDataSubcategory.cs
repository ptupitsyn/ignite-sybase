// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AggrDataSubcategory : IBinarizable, ICanReadFromRecordBuffer
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
        [QuerySqlField(Name = "outlet")] public long Outlet { get; set; }
        [QuerySqlField(Name = "outletfamily")] public long Outletfamily { get; set; }
        [QuerySqlField(Name = "wearertype")] public long Wearertype { get; set; }
        [QuerySqlField(Name = "classification")] public long Classification { get; set; }
        [QuerySqlField(Name = "class")] public long Class { get; set; }
        [QuerySqlField(Name = "wearersubtype")] public long Wearersubtype { get; set; }
        [QuerySqlField(Name = "channel")] public long Channel { get; set; }
        [QuerySqlField(Name = "categorytype")] public long Categorytype { get; set; }
        [QuerySqlField(Name = "category")] public long Category { get; set; }
        [QuerySqlField(Name = "wearersize")] public long Wearersize { get; set; }
        [QuerySqlField(Name = "wearersegment")] public long Wearersegment { get; set; }
        [QuerySqlField(Name = "wearergender")] public long Wearergender { get; set; }
        [QuerySqlField(Name = "superchannel")] public long Superchannel { get; set; }
        [QuerySqlField(Name = "supercategory")] public long Supercategory { get; set; }
        [QuerySqlField(Name = "subclass")] public long Subclass { get; set; }
        [QuerySqlField(Name = "subchannel")] public long Subchannel { get; set; }
        [QuerySqlField(Name = "retailerregion")] public long Retailerregion { get; set; }
        [QuerySqlField(Name = "brandtype")] public long Brandtype { get; set; }
        [QuerySqlField(Name = "brandfamily")] public long Brandfamily { get; set; }
        [QuerySqlField(Name = "brand")] public long Brand { get; set; }
        [QuerySqlField(Name = "censusdivisionusa")] public long Censusdivisionusa { get; set; }
        [QuerySqlField(Name = "censusregionusa")] public long Censusregionusa { get; set; }
        [QuerySqlField(Name = "state")] public long State { get; set; }
        [QuerySqlField(Name = "inventory")] public double Inventory { get; set; }
        [QuerySqlField(Name = "unitssold")] public double Unitssold { get; set; }
        [QuerySqlField(Name = "totalvalue")] public double Totalvalue { get; set; }
        [QuerySqlField(Name = "trans")] public double Trans { get; set; }
        [QuerySqlField(Name = "proj_inventory")] public double ProjInventory { get; set; }
        [QuerySqlField(Name = "proj_unitssold")] public double ProjUnitssold { get; set; }
        [QuerySqlField(Name = "proj_totalvalue")] public double ProjTotalvalue { get; set; }
        [QuerySqlField(Name = "stores_totalvalue")] public double StoresTotalvalue { get; set; }
        [QuerySqlField(Name = "store_weight")] public string StoreWeight { get; set; }
        [QuerySqlField(Name = "totind_stores_totalvalue")] public double TotindStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "proj_stores_totalvalue")] public double ProjStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "totind_proj_stores_totalvalue")] public double TotindProjStoresTotalvalue { get; set; }
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
            writer.WriteLong("outlet", Outlet);
            writer.WriteLong("outletfamily", Outletfamily);
            writer.WriteLong("wearertype", Wearertype);
            writer.WriteLong("classification", Classification);
            writer.WriteLong("class", Class);
            writer.WriteLong("wearersubtype", Wearersubtype);
            writer.WriteLong("channel", Channel);
            writer.WriteLong("categorytype", Categorytype);
            writer.WriteLong("category", Category);
            writer.WriteLong("wearersize", Wearersize);
            writer.WriteLong("wearersegment", Wearersegment);
            writer.WriteLong("wearergender", Wearergender);
            writer.WriteLong("superchannel", Superchannel);
            writer.WriteLong("supercategory", Supercategory);
            writer.WriteLong("subclass", Subclass);
            writer.WriteLong("subchannel", Subchannel);
            writer.WriteLong("retailerregion", Retailerregion);
            writer.WriteLong("brandtype", Brandtype);
            writer.WriteLong("brandfamily", Brandfamily);
            writer.WriteLong("brand", Brand);
            writer.WriteLong("censusdivisionusa", Censusdivisionusa);
            writer.WriteLong("censusregionusa", Censusregionusa);
            writer.WriteLong("state", State);
            writer.WriteDouble("inventory", Inventory);
            writer.WriteDouble("unitssold", Unitssold);
            writer.WriteDouble("totalvalue", Totalvalue);
            writer.WriteDouble("trans", Trans);
            writer.WriteDouble("proj_inventory", ProjInventory);
            writer.WriteDouble("proj_unitssold", ProjUnitssold);
            writer.WriteDouble("proj_totalvalue", ProjTotalvalue);
            writer.WriteDouble("stores_totalvalue", StoresTotalvalue);
            writer.WriteString("store_weight", StoreWeight);
            writer.WriteDouble("totind_stores_totalvalue", TotindStoresTotalvalue);
            writer.WriteDouble("proj_stores_totalvalue", ProjStoresTotalvalue);
            writer.WriteDouble("totind_proj_stores_totalvalue", TotindProjStoresTotalvalue);
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
            Outlet = reader.ReadLong("outlet");
            Outletfamily = reader.ReadLong("outletfamily");
            Wearertype = reader.ReadLong("wearertype");
            Classification = reader.ReadLong("classification");
            Class = reader.ReadLong("class");
            Wearersubtype = reader.ReadLong("wearersubtype");
            Channel = reader.ReadLong("channel");
            Categorytype = reader.ReadLong("categorytype");
            Category = reader.ReadLong("category");
            Wearersize = reader.ReadLong("wearersize");
            Wearersegment = reader.ReadLong("wearersegment");
            Wearergender = reader.ReadLong("wearergender");
            Superchannel = reader.ReadLong("superchannel");
            Supercategory = reader.ReadLong("supercategory");
            Subclass = reader.ReadLong("subclass");
            Subchannel = reader.ReadLong("subchannel");
            Retailerregion = reader.ReadLong("retailerregion");
            Brandtype = reader.ReadLong("brandtype");
            Brandfamily = reader.ReadLong("brandfamily");
            Brand = reader.ReadLong("brand");
            Censusdivisionusa = reader.ReadLong("censusdivisionusa");
            Censusregionusa = reader.ReadLong("censusregionusa");
            State = reader.ReadLong("state");
            Inventory = reader.ReadDouble("inventory");
            Unitssold = reader.ReadDouble("unitssold");
            Totalvalue = reader.ReadDouble("totalvalue");
            Trans = reader.ReadDouble("trans");
            ProjInventory = reader.ReadDouble("proj_inventory");
            ProjUnitssold = reader.ReadDouble("proj_unitssold");
            ProjTotalvalue = reader.ReadDouble("proj_totalvalue");
            StoresTotalvalue = reader.ReadDouble("stores_totalvalue");
            StoreWeight = reader.ReadString("store_weight");
            TotindStoresTotalvalue = reader.ReadDouble("totind_stores_totalvalue");
            ProjStoresTotalvalue = reader.ReadDouble("proj_stores_totalvalue");
            TotindProjStoresTotalvalue = reader.ReadDouble("totind_proj_stores_totalvalue");
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
                Outlet = *(long*) (p + 280);
                Outletfamily = *(long*) (p + 288);
                Wearertype = *(long*) (p + 296);
                Classification = *(long*) (p + 304);
                Class = *(long*) (p + 312);
                Wearersubtype = *(long*) (p + 320);
                Channel = *(long*) (p + 328);
                Categorytype = *(long*) (p + 336);
                Category = *(long*) (p + 344);
                Wearersize = *(long*) (p + 352);
                Wearersegment = *(long*) (p + 360);
                Wearergender = *(long*) (p + 368);
                Superchannel = *(long*) (p + 376);
                Supercategory = *(long*) (p + 384);
                Subclass = *(long*) (p + 392);
                Subchannel = *(long*) (p + 400);
                Retailerregion = *(long*) (p + 408);
                Brandtype = *(long*) (p + 416);
                Brandfamily = *(long*) (p + 424);
                Brand = *(long*) (p + 432);
                Censusdivisionusa = *(long*) (p + 440);
                Censusregionusa = *(long*) (p + 448);
                State = *(long*) (p + 456);
                Inventory = *(double*) (p + 464);
                Unitssold = *(double*) (p + 472);
                Totalvalue = *(double*) (p + 480);
                Trans = *(double*) (p + 488);
                ProjInventory = *(double*) (p + 496);
                ProjUnitssold = *(double*) (p + 504);
                ProjTotalvalue = *(double*) (p + 512);
                StoresTotalvalue = *(double*) (p + 520);
                StoreWeight = Encoding.ASCII.GetString(buffer, 528, 64).TrimEnd();
                TotindStoresTotalvalue = *(double*) (p + 592);
                ProjStoresTotalvalue = *(double*) (p + 600);
                TotindProjStoresTotalvalue = *(double*) (p + 608);
                ProjUnitPrice = *(double*) (p + 616);
                StoreSublvlTotalvalue = *(double*) (p + 624);
                PostalSublvlTotalvalue = *(double*) (p + 632);
                Outletallocation = *(long*) (p + 640);
                Outletpostalcode = Encoding.ASCII.GetString(buffer, 648, 64).TrimEnd();
                ActualUnits = *(double*) (p + 712);
                ProjActualUnits = *(double*) (p + 720);
                Numweeks = *(long*) (p + 728);
                RdollarsAdj = *(double*) (p + 736);
                DollarsAdj = *(double*) (p + 744);
                UnitsAdj = *(double*) (p + 752);
                RunitsAdj = *(double*) (p + 760);
            }
        }
    }
}
