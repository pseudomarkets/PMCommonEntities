using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.PseudoXchange.OrderEntryModels
{
    public class OrderEntry
    {
        public string Token { get; set; }
        public string Symbol { get; set; }
        public int Quantity { get; set; }
        public Enums.OrderTypes OrderType { get; set; }
        public Enums.OrderRules OrderRules { get; set; }
        public double LowerLimitPrice { get; set; }
        public double UpperLimitPrice { get; set; }
        public Enums.OrderFillSettings OrderFillSettings { get; set; }
        public Enums.OrderPricing OrderPricing { get; set; }
        public Enums.OrderStatus OrderStatus { get; set; }
        public int AccountId { get; set; }
    }
}
