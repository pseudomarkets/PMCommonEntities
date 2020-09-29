using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace PMCommonEntities.Models.PseudoXchange.OrderEntryModels
{
    [MessagePackObject]
    public class OrderEntryResult
    {
        [Key(0)]
        public string Status { get; set; }
        [Key(1)]
        public string TransactionId { get; set; }
        [Key(2)]
        public DateTime Timestamp { get; set; }
    }
}
