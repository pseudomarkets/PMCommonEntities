using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.PseudoXchange.OrderEntryModels
{
    public class Enums
    {
        public enum OrderTypes : int
        {
            Buy = 0,
            Sell = 1
        }

        public enum OrderRules : int
        {
            GoodUntilCancelled = 0,
            GoodUntilEndOfDay = 1,
            GoodUntilCancelledOrEndOfDay = 2
        }

        public enum OrderPricing : int
        {
            Limit = 0
        }

        public enum OrderFillSettings : int
        {
            AllFillBuy = 0,
            AllFillSell = 1,
            PartialFillBuy = 2,
            PartialFillSell = 3
        }

        public enum OrderStatus : int
        {
            Open = 0,
            Closed = 1,
            Cancelled = 2
        }
    }
}
