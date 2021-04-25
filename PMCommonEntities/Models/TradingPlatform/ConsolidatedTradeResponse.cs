using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;
using PMUnifiedAPI.Models;

namespace PMCommonEntities.Models.TradingPlatform
{
    [MessagePackObject]
    public class ConsolidatedTradeResponse
    {
        [Key(0)]
        public string StatusMessage { get; set; }

        [Key(1)]
        public ConsolidatedTradeEnums.TradeStatusCodes StatusCode { get; set; }

        [Key(2)]
        public Orders Order { get; set; }
    }
}
