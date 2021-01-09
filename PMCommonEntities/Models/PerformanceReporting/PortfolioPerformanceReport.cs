using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;


namespace PMCommonEntities.Models.PerformanceReporting
{
    [BsonIgnoreExtraElements]
    public class PortfolioPerformanceReport
    {
        public int AccountId { get; set; }
        public DateTime ReportDate { get; set; }
        public double CurrentCashBalance { get; set; }
        public double CurrentInvestmentValue { get; set; }
        public double CurrentTotalAccountValue { get; set; }
        public double PortfolioUgl { get; set; }
        public double PortfolioUglPercentage { get; set; }
        public List<PositionPerformance> PortfolioPerformance { get; set; }
    }
}
