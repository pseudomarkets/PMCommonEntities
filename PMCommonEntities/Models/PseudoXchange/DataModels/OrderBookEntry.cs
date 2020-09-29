using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace PMCommonEntities.Models.PseudoXchange.DataModels
{
    [MessagePackObject]
    public class OrderBookEntry
    {
        [Key(0)]
        public string Symbol { get; set; }
        [Key(1)]
        public double LastSoldPrice { get; set; }
        [Key(2)]
        public DateTime Timestamp { get; set; }
        [Key(3)]
        public int BuyVolume { get; set; }
        [Key(4)]
        public int SellVolume { get; set; }
    }
}
