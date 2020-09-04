using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models
{
    public class PseudoFunds
    {
        public int Id { get; set; }
        public string FundName { get; set; }
        public string FundTicker { get; set; }
        public string FundDescription { get; set; }
        public double InitialInvestment { get; set; }
        public int SharesOutstanding { get; set; }
    }
}
