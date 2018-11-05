// ReSharper disable All
using System.Text;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache.Configuration;

namespace Apache.Ignite.Sybase.Ingest.Cache
{
    public class AggrStoreAivMon : IBinarizable, ICanReadFromRecordBuffer
    {
        [QuerySqlField(Name = "ppmonth")] public long Ppmonth { get; set; }
        [QuerySqlField(Name = "distributor")] public long Distributor { get; set; }
        [QuerySqlField(Name = "storeid")] public string Storeid { get; set; }
        [QuerySqlField(Name = "postalcode")] public string Postalcode { get; set; }
        [QuerySqlField(Name = "outletstoreid")] public string Outletstoreid { get; set; }
        [QuerySqlField(Name = "dma")] public long Dma { get; set; }
        [QuerySqlField(Name = "year")] public long Year { get; set; }
        [QuerySqlField(Name = "yearhalf")] public long Yearhalf { get; set; }
        [QuerySqlField(Name = "yearqtr")] public long Yearqtr { get; set; }
        [QuerySqlField(Name = "yearmonth")] public long Yearmonth { get; set; }
        [QuerySqlField(Name = "outletfamily")] public long Outletfamily { get; set; }
        [QuerySqlField(Name = "channel")] public long Channel { get; set; }
        [QuerySqlField(Name = "superchannel")] public long Superchannel { get; set; }
        [QuerySqlField(Name = "retailerregion")] public long Retailerregion { get; set; }
        [QuerySqlField(Name = "subchannel")] public long Subchannel { get; set; }
        [QuerySqlField(Name = "outlet")] public long Outlet { get; set; }
        [QuerySqlField(Name = "state")] public long State { get; set; }
        [QuerySqlField(Name = "censusdivisionusa")] public long Censusdivisionusa { get; set; }
        [QuerySqlField(Name = "censusregionusa")] public long Censusregionusa { get; set; }
        [QuerySqlField(Name = "totind_stores_totalvalue")] public double TotindStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "stores_totalvalue")] public double StoresTotalvalue { get; set; }
        [QuerySqlField(Name = "numbermonths")] public long Numbermonths { get; set; }
        [QuerySqlField(Name = "ppweek")] public long Ppweek { get; set; }
        [QuerySqlField(Name = "proj_stores_totalvalue")] public double ProjStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "totind_proj_stores_totalvalue")] public double TotindProjStoresTotalvalue { get; set; }
        [QuerySqlField(Name = "factors_totalvalue")] public double FactorsTotalvalue { get; set; }
        [QuerySqlField(Name = "store_weight")] public string StoreWeight { get; set; }

        public void WriteBinary(IBinaryWriter writer)
        {
            writer.WriteLong("ppmonth", Ppmonth);
            writer.WriteLong("distributor", Distributor);
            writer.WriteString("storeid", Storeid);
            writer.WriteString("postalcode", Postalcode);
            writer.WriteString("outletstoreid", Outletstoreid);
            writer.WriteLong("dma", Dma);
            writer.WriteLong("year", Year);
            writer.WriteLong("yearhalf", Yearhalf);
            writer.WriteLong("yearqtr", Yearqtr);
            writer.WriteLong("yearmonth", Yearmonth);
            writer.WriteLong("outletfamily", Outletfamily);
            writer.WriteLong("channel", Channel);
            writer.WriteLong("superchannel", Superchannel);
            writer.WriteLong("retailerregion", Retailerregion);
            writer.WriteLong("subchannel", Subchannel);
            writer.WriteLong("outlet", Outlet);
            writer.WriteLong("state", State);
            writer.WriteLong("censusdivisionusa", Censusdivisionusa);
            writer.WriteLong("censusregionusa", Censusregionusa);
            writer.WriteDouble("totind_stores_totalvalue", TotindStoresTotalvalue);
            writer.WriteDouble("stores_totalvalue", StoresTotalvalue);
            writer.WriteLong("numbermonths", Numbermonths);
            writer.WriteLong("ppweek", Ppweek);
            writer.WriteDouble("proj_stores_totalvalue", ProjStoresTotalvalue);
            writer.WriteDouble("totind_proj_stores_totalvalue", TotindProjStoresTotalvalue);
            writer.WriteDouble("factors_totalvalue", FactorsTotalvalue);
            writer.WriteString("store_weight", StoreWeight);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppmonth = reader.ReadLong("ppmonth");
            Distributor = reader.ReadLong("distributor");
            Storeid = reader.ReadString("storeid");
            Postalcode = reader.ReadString("postalcode");
            Outletstoreid = reader.ReadString("outletstoreid");
            Dma = reader.ReadLong("dma");
            Year = reader.ReadLong("year");
            Yearhalf = reader.ReadLong("yearhalf");
            Yearqtr = reader.ReadLong("yearqtr");
            Yearmonth = reader.ReadLong("yearmonth");
            Outletfamily = reader.ReadLong("outletfamily");
            Channel = reader.ReadLong("channel");
            Superchannel = reader.ReadLong("superchannel");
            Retailerregion = reader.ReadLong("retailerregion");
            Subchannel = reader.ReadLong("subchannel");
            Outlet = reader.ReadLong("outlet");
            State = reader.ReadLong("state");
            Censusdivisionusa = reader.ReadLong("censusdivisionusa");
            Censusregionusa = reader.ReadLong("censusregionusa");
            TotindStoresTotalvalue = reader.ReadDouble("totind_stores_totalvalue");
            StoresTotalvalue = reader.ReadDouble("stores_totalvalue");
            Numbermonths = reader.ReadLong("numbermonths");
            Ppweek = reader.ReadLong("ppweek");
            ProjStoresTotalvalue = reader.ReadDouble("proj_stores_totalvalue");
            TotindProjStoresTotalvalue = reader.ReadDouble("totind_proj_stores_totalvalue");
            FactorsTotalvalue = reader.ReadDouble("factors_totalvalue");
            StoreWeight = reader.ReadString("store_weight");
        }

        public unsafe void ReadFromRecordBuffer(byte[] buffer)
        {
            fixed (byte* p = &buffer[0])
            {
                Ppmonth = *(long*) (p + 0);
                Distributor = *(long*) (p + 8);
                Storeid = Encoding.ASCII.GetString(buffer, 16, 64).TrimEnd();
                Postalcode = Encoding.ASCII.GetString(buffer, 80, 64).TrimEnd();
                Outletstoreid = Encoding.ASCII.GetString(buffer, 144, 64).TrimEnd();
                Dma = *(long*) (p + 208);
                Year = *(long*) (p + 216);
                Yearhalf = *(long*) (p + 224);
                Yearqtr = *(long*) (p + 232);
                Yearmonth = *(long*) (p + 240);
                Outletfamily = *(long*) (p + 248);
                Channel = *(long*) (p + 256);
                Superchannel = *(long*) (p + 264);
                Retailerregion = *(long*) (p + 272);
                Subchannel = *(long*) (p + 280);
                Outlet = *(long*) (p + 288);
                State = *(long*) (p + 296);
                Censusdivisionusa = *(long*) (p + 304);
                Censusregionusa = *(long*) (p + 312);
                TotindStoresTotalvalue = *(double*) (p + 320);
                StoresTotalvalue = *(double*) (p + 328);
                Numbermonths = *(long*) (p + 336);
                Ppweek = *(long*) (p + 344);
                ProjStoresTotalvalue = *(double*) (p + 352);
                TotindProjStoresTotalvalue = *(double*) (p + 360);
                FactorsTotalvalue = *(double*) (p + 368);
                StoreWeight = Encoding.ASCII.GetString(buffer, 376, 64).TrimEnd();
            }
        }
    }
}
