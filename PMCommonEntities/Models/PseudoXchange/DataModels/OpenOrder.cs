using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;
using PMCommonEntities.Models.PseudoXchange.OrderEntryModels;

namespace PMCommonEntities.Models.PseudoXchange.DataModels
{
    [MessagePackObject]
    public class OpenOrder
    {
        [Key(0)]
        public int Quantity { get; set; }
        [Key(1)]
        public Enums.OrderTypes OrderType { get; set; }
        [Key(2)]
        public Enums.OrderRules OrderRules { get; set; }
        [Key(3)]
        public double LowerLimitPrice { get; set; }
        [Key(3)]
        public double UpperLimitPrice { get; set; }
        [Key(4)]
        public Enums.OrderFillSettings OrderFillSettings { get; set; }
        [Key(5)]
        public Enums.OrderPricing OrderPricing { get; set; }
        [Key(6)]
        public DateTime Timestamp { get; set; }
        [Key(7)]
        public Enums.OrderStatus OrderStatus { get; set; }
        [Key(8)]
        public string TransactionId { get; set; }
    }
}
