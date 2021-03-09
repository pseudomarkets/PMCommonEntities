using System;
using System.Collections.Generic;
using System.Text;

namespace PMCommonEntities.Models
{
    public class RDSEnums
    {
        public enum OriginId : int
        {
            PseudoMarkets = 1,
            PseudoXchange = 2,
            PseudoFund = 3,
        }

        public enum EnvironmentId : int
        {
            ProductionPrimary = 1,
            ProductionSecondary = 2,
            RdsFallback = 3,
            DisasterRecoveryBackup = 4
        }

        public enum SecurityType : int
        {
            RealWorld = 1,
            Simulated = 2
        }
    }
}
