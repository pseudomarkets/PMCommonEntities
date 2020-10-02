using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace PMCommonEntities.Models.PseudoXchange.OrderEntryModels
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

    [MessagePackObject]
    public class XchangeOrder
    {
        [Key(0)]
        public string Symbol { get; set; }
        [Key(1)]
        public int Quantity { get; set; }
        [Key(2)]
        public OrderTypes OrderType { get; set; }
        [Key(3)]
        public OrderRules OrderRules { get; set; }
        [Key(4)]
        public double LowerLimitPrice { get; set; }
        [Key(5)]
        public double UpperLimitPrice { get; set; }
        [Key(6)]
        public OrderFillSettings OrderFillSettings { get; set; }
        [Key(7)]
        public OrderPricing OrderPricing { get; set; }
        [Key(8)]
        public OrderStatus OrderStatus { get; set; }
        [Key(9)]
        public int AccountId { get; set; }
    }
}
