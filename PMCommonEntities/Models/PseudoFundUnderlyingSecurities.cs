using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models
{
    public class PseudoFundUnderlyingSecurities
    {
        public int Id { get; set; }
        public int FundId { get; set; }
        public string Ticker { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }
        public RDSEnums.EnvironmentId EnvironmentId { get; set; }
    }
}
