using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.TradingPlatform
{
    public class ConsolidatedTradeEnums
    {
        public enum ConsolidatedOrderType
        {
            Market,
            Limit,
            Stop,
            StopLimit
        }

        public enum ConsolidatedOrderTiming
        {
            DayOnly,
            AfterHours
        }

        public enum ConsolidatedOrderOrigin
        {
            PseudoMarkets,
            PseudoXchange
        }

        public enum DataStore
        {
            Legacy,
            RealTime,
            Dual
        }

        public enum TradeStatusCodes : int
        {
            ExecutionOk = 0,
            ExecutionQueued = 1,
            ExecutionError = -1
        }
    }
}
