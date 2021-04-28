using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace PMCommonEntities.Models.TradingPlatform
{
    [MessagePackObject]
    public class ConsolidatedTradeRequest
    {
        [Key(0)] public string Symbol { get; set; }

        [Key(1)] public int Quantity { get; set; }

        [Key(2)] public string OrderAction { get; set; }

        [Key(3)] public ConsolidatedTradeEnums.ConsolidatedOrderType OrderType { get; set; }

        [Key(4)] public ConsolidatedTradeEnums.ConsolidatedOrderTiming OrderTiming { get; set; }

        [Key(5)] public ConsolidatedTradeEnums.ConsolidatedOrderOrigin OrderOrigin { get; set; }

        [Key(6)] public int AccountId { get; set; }

        [Key(7)]
        public OrderDrainerMessage OrderDrainerMessage { get; set; }

        [Key(8)]
        public bool EnforceMarketOpenCheck { get; set; }
    }
}
