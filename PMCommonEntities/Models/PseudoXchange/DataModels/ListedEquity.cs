using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.PseudoXchange.DataModels
{
    public class ListedEquity
    {
        public string Symbol { get; set; }
        public double InitialListPrice { get; set; }
        public string Description { get; set; }
        public DateTime ListingDate { get; set; }
        public XchangeListingStatus ListingStatus { get; set; }
    }

    public enum XchangeListingStatus : int
    {
        Active = 1,
        Inactive = 2,
        Restricted = 3
    }
}
