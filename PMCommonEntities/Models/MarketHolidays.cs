using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models
{
    public class MarketHolidays
    {
        public int Id { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Description { get; set; }
    }
}
