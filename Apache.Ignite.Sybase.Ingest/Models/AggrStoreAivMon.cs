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
            writer.WriteLong(nameof(Ppmonth), Ppmonth);
            writer.WriteLong(nameof(Distributor), Distributor);
            writer.WriteString(nameof(Storeid), Storeid);
            writer.WriteString(nameof(Postalcode), Postalcode);
            writer.WriteString(nameof(Outletstoreid), Outletstoreid);
            writer.WriteLong(nameof(Dma), Dma);
            writer.WriteLong(nameof(Year), Year);
            writer.WriteLong(nameof(Yearhalf), Yearhalf);
            writer.WriteLong(nameof(Yearqtr), Yearqtr);
            writer.WriteLong(nameof(Yearmonth), Yearmonth);
            writer.WriteLong(nameof(Outletfamily), Outletfamily);
            writer.WriteLong(nameof(Channel), Channel);
            writer.WriteLong(nameof(Superchannel), Superchannel);
            writer.WriteLong(nameof(Retailerregion), Retailerregion);
            writer.WriteLong(nameof(Subchannel), Subchannel);
            writer.WriteLong(nameof(Outlet), Outlet);
            writer.WriteLong(nameof(State), State);
            writer.WriteLong(nameof(Censusdivisionusa), Censusdivisionusa);
            writer.WriteLong(nameof(Censusregionusa), Censusregionusa);
            writer.WriteDouble(nameof(TotindStoresTotalvalue), TotindStoresTotalvalue);
            writer.WriteDouble(nameof(StoresTotalvalue), StoresTotalvalue);
            writer.WriteLong(nameof(Numbermonths), Numbermonths);
            writer.WriteLong(nameof(Ppweek), Ppweek);
            writer.WriteDouble(nameof(ProjStoresTotalvalue), ProjStoresTotalvalue);
            writer.WriteDouble(nameof(TotindProjStoresTotalvalue), TotindProjStoresTotalvalue);
            writer.WriteDouble(nameof(FactorsTotalvalue), FactorsTotalvalue);
            writer.WriteString(nameof(StoreWeight), StoreWeight);
        }

        public void ReadBinary(IBinaryReader reader)
        {
            Ppmonth = reader.ReadLong(nameof(Ppmonth));
            Distributor = reader.ReadLong(nameof(Distributor));
            Storeid = reader.ReadString(nameof(Storeid));
            Postalcode = reader.ReadString(nameof(Postalcode));
            Outletstoreid = reader.ReadString(nameof(Outletstoreid));
            Dma = reader.ReadLong(nameof(Dma));
            Year = reader.ReadLong(nameof(Year));
            Yearhalf = reader.ReadLong(nameof(Yearhalf));
            Yearqtr = reader.ReadLong(nameof(Yearqtr));
            Yearmonth = reader.ReadLong(nameof(Yearmonth));
            Outletfamily = reader.ReadLong(nameof(Outletfamily));
            Channel = reader.ReadLong(nameof(Channel));
            Superchannel = reader.ReadLong(nameof(Superchannel));
            Retailerregion = reader.ReadLong(nameof(Retailerregion));
            Subchannel = reader.ReadLong(nameof(Subchannel));
            Outlet = reader.ReadLong(nameof(Outlet));
            State = reader.ReadLong(nameof(State));
            Censusdivisionusa = reader.ReadLong(nameof(Censusdivisionusa));
            Censusregionusa = reader.ReadLong(nameof(Censusregionusa));
            TotindStoresTotalvalue = reader.ReadDouble(nameof(TotindStoresTotalvalue));
            StoresTotalvalue = reader.ReadDouble(nameof(StoresTotalvalue));
            Numbermonths = reader.ReadLong(nameof(Numbermonths));
            Ppweek = reader.ReadLong(nameof(Ppweek));
            ProjStoresTotalvalue = reader.ReadDouble(nameof(ProjStoresTotalvalue));
            TotindProjStoresTotalvalue = reader.ReadDouble(nameof(TotindProjStoresTotalvalue));
            FactorsTotalvalue = reader.ReadDouble(nameof(FactorsTotalvalue));
            StoreWeight = reader.ReadString(nameof(StoreWeight));
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
