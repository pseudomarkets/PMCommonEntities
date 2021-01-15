using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.PseudoXchange
{
    public class XchangeSharedNamespace
    {
        public string Namespace = "nsShared";

        public class SetOpenOrders
        {
            public string Set = "setOpenOrders";
            public string SymbolBin = "bSymbol";
            public string OrderDataBin = "bOrder";
            public string TimestampBin = "bDate";
        }

        public class SetClosedOrders
        {
            public string Set = "setClosedOrders";
            public string SymbolBin = "bSymbol";
            public string OrderDataBin = "bOrder";
            public string TimestampBin = "bDate";
        }

        public class SetOrderBook
        {
            public string Set = "setOrderBook";
            public string SymbolBin = "bSymbol";
            public string LastSoldPriceBin = "bPrice";
            public string LastTradeTimeBin = "bTime";
            public string BuyVolumeBin = "bBVol";
            public string SellVolumeBin = "bSVol";
        }

        public class SetEquities
        {
            public string Set = "setEquities";
            public string SymbolBin = "bSymbol";
            public string InitialPriceBin = "bInit";
            public string DescriptionBin = "bDesc";
            public string ListingStatusBin = "bStatus";
            public string ListingDateBin = "bLstDt";
        }
    }

    public class XchangeInMemNamespace
    {
        public string Namespace = "nsInMem";
    }
}
