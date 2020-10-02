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
        public OrderTypes OrderType { get; set; }
        public OrderRules OrderRules { get; set; }
        public double LowerLimitPrice { get; set; }
        public double UpperLimitPrice { get; set; }
        public OrderFillSettings OrderFillSettings { get; set; }
        public OrderPricing OrderPricing { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int AccountId { get; set; }
    }
}
