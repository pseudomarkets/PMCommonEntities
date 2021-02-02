using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace PMCommonEntities.Models.CachedData
{
    [MessagePackObject]
    public class CachedDetailedQuote
    {
        [Key(0)]
        public string Symbol { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public DateTime Timestamp { get; set; }
        [Key(3)]
        public double Open { get; set; }
        [Key(4)]
        public double Close { get; set; }
        [Key(5)]
        public double High { get; set; }
        [Key(6)]
        public double Low { get; set; }
        [Key(7)]
        public long Volume { get; set; }
        [Key(8)]
        public double PreviousClose { get; set; }
        [Key(9)]
        public double Change { get; set; }
        [Key(10)]
        public double ChangePercentage { get; set; }
    }
}
