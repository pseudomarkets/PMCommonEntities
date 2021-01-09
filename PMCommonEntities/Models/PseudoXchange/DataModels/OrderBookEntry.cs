using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace PMCommonEntities.Models.PseudoXchange.DataModels
{
    public class OrderBookEntry
    {
        // Store directly in applicable bins (these values get updated often so we'd be serializing/deserializing too much)
        public string Symbol { get; set; }
        public double LastSoldPrice { get; set; }
        public DateTime LastTradeTime { get; set; }
        public long BuyVolume { get; set; }
        public long SellVolume { get; set; }
    }
}
