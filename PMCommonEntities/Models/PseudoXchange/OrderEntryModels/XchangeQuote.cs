using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.PseudoXchange.OrderEntryModels
{
    public class XchangeQuote
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
