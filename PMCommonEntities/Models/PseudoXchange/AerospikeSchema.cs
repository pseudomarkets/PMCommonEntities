using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.PseudoXchange
{
    public static class XchangeSharedNamespace
    {
        public const string Namespace = "nsShared";

        public static class SetOpenOrders
        {
            public const string Set = "setOpenOrders";
            public const string SymbolBin = "bSymbol";
            public const string OrderDataBin = "bOrder";
            public const string TimestampBin = "bDate";
        }

        public static class SetClosedOrders
        {
            public const string Set = "setClosedOrders";
            public const string SymbolBin = "bSymbol";
            public const string OrderDataBin = "bOrder";
            public const string TimestampBin = "bDate";
        }

        public static class SetOrderBook
        {
            public const string Set = "setOrderBook";
            public const string SymbolBin = "bSymbol";
            public const string LastSoldPriceBin = "bPrice";
            public const string BidPriceBin = "bBid";
            public const string AskPriceBin = "bAsk";
            public const string LastTradeTimeBin = "bTime";
            public const string BuyVolumeBin = "bBVol";
            public const string SellVolumeBin = "bSVol";
        }

        public static class SetEquities
        {
            public const string Set = "setEquities";
            public const string SymbolBin = "bSymbol";
            public const string InitialPriceBin = "bInit";
            public const string DescriptionBin = "bDesc";
            public const string ListingStatusBin = "bStatus";
            public const string ListingDateBin = "bLstDt";
        }
    }

    public static class XchangeInMemNamespace
    {
        public const string Namespace = "nsInMem";

        public static class SetLatestPriceCache
        {
            public const string Set = "setPriceCache";
            public const string CachedPriceBin = "bPrice";
        }

        public static class SetAggregatePriceCache
        {
            public const string Set = "setAggrPriceCache";
            public const string CachedPriceBin = "bPrice";
        }

        public static class SetIndicesCache
        {
            public const string Set = "setIdicesCache";
            public const string DowPointsBin = "bDow";
            public const string Sp500PointsBin = "bSp";
            public const string NasdaqPointsBin = "bNsdq";
        }
    }
}
