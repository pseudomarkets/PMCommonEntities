using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;
using PMCommonEntities.Models.PseudoXchange.OrderEntryModels;

namespace PMCommonEntities.Models.PseudoXchange.DataModels
{
    [MessagePackObject]
    public class ClosedOrder
    {
        [Key(0)]
        public string Symbol { get; set; }
        [Key(1)]
        public int Quantity { get; set; }
        [Key(2)]
        public Enums.OrderTypes OrderType { get; set; }
        [Key(3)]
        public Enums.OrderRules OrderRules { get; set; }
        [Key(4)]
        public double ExecutedPrice { get; set; }
        [Key(5)]
        public Enums.OrderFillSettings OrderFillSettings { get; set; }
        [Key(6)]
        public Enums.OrderPricing OrderPricing { get; set; }
        [Key(7)]
        public DateTime Timestamp { get; set; }
        [Key(8)]
        public Enums.OrderStatus OrderStatus { get; set; }
        [Key(9)]
        public string TransactionId { get; set; }
    }
}
