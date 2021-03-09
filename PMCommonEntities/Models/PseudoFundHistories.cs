using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models
{
    public class PseudoFundHistories
    {
        public int Id { get; set; }
        public int FundId { get; set; }
        public double CurrentNav { get; set; }
        public DateTime ClosingDate { get; set; }
        public RDSEnums.EnvironmentId EnvironmentId { get; set; }
    }
}
