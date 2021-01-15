using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace PMCommonEntities.Models.HistoricalData
{
    [BsonIgnoreExtraElements]
    public class HistoricalStockData
    {
        public string Symbol { get; set; }
        public double ClosingPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
