using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models.PseudoMarkets
{
    public static class PseudoMarketsSharedNamespace
    {
        public const string ProdNamespace = "nsShared";
        public const string DevNamespace = "nsInMem";

        public static class SetOrders
        {
            public const string Set = "setPMOrders";
            public const string LegacyOrderIdBin = "bLgcyId";
            public const string SymbolBin = "bSymbl";
            public const string TypeBin = "bType";
            public const string QuantityBin = "bQuantity";
            public const string DateBin = "bDate";
            public const string TransactionIdBin = "bTranId";
            public const string EnvironmentIdBin = "bEnvId";
            public const string OriginIdBin = "bOrigId";
            public const string SecurityTypeIdBin = "bSecTypId";
            public const string AccountingIdBin = "bActgId";
        }

        public static class SetAccounts
        {
            public const string Set = "setPMAccounts";
            public const string UserIdBin = "bUser";
            public const string LegacyUserIdBin = "bLgcyUsr";
            public const string LegacyAccountIdBin = "bLgcyAcct";
            public const string CashBalanceBin = "bCashBal";
            public const string MarginBalanceBin = "bMrgnBal";
            public const string EnvironmentIdBin = "bEnvId";
        }

        public static class SetPositions
        {
            public const string Set = "setPMPositions";
            public const string AccountIdBin = "bAcctId";
            public const string LegacyAccountIdBin = "bLgcyAcct";
            public const string LegacyOrderIdBin = "bLgcyOrd";
            public const string OrderValueBin = "bOrdVal";
            public const string SharePriceBin = "bPrice";
            public const string OrderQuantityBin = "bQuantity";
            public const string SecurityTypeIdBin = "bSecType";
            public const string OriginIdBin = "bOrigId";
            public const string EnvironmentIdBin = "bEnvId";
        }

        public static class SetTransactions
        {
            public const string Set = "setPMTransactions";
            public const string AccountId = "bAcctId";
            public const string LegacyAccountId = "bLgcyAcct";
            public const string OriginId = "bOrigId";
            public const string EnvironmentId = "bEnvId";
        }

        public static class SetUsers
        {
            public const string Set = "setPMUsers";
            public const string LegacyUserIdBin = "bLgcyUsr";
            public const string UsernameBin = "bUsrName";
            public const string PasswordBin = "bPasswd";
            public const string SaltBin = "bSalt";
            public const string EnvironmentIdBin = "bEnvId";
        }

        public static class SetQueuedOrders
        {

        }

        public static class SetMarketHolidays
        {

        }

        public static class SetDbSyncStatus
        {

        }

        public static class SetPositionTradeLots
        {

        }
    }
}
