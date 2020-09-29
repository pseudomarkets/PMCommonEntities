﻿using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;
using PMCommonEntities.Models.PseudoXchange.OrderEntryModels;

namespace PMCommonEntities.Models.PseudoXchange.DataModels
{
    [MessagePackObject]
    public class OpenBuyOrder
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
        public DateTime Timestamp { get; set; }
        [Key(9)]
        public OrderStatus OrderStatus { get; set; }
        [Key(10)]
        public string TransactionId { get; set; }
    }
}