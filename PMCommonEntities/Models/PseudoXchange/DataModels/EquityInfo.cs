using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.PseudoXchange.DataModels
{
    public class EquityInfo
    {
        public string Symbol { get; set; }
        public string Description { get; set; }
        public DateTime ListDate { get; set; }
        public double InitialListPrice { get; set; }
        public bool IsCurrentlyListed { get; set; }
    }
}
