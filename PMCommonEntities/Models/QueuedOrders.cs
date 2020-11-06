using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models
{
    public class QueuedOrders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Symbol { get; set; }
        public string OrderType { get; set; }
        public int Quantity { get; set; }
        public bool IsOpenOrder { get; set; }
    }
}
