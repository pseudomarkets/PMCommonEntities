using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PMCommonEntities;
using PMCommonEntities.Models;

namespace PMUnifiedAPI.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string TransactionId { get; set; }
        public RDSEnums.OriginId OriginId { get; set; }
        public RDSEnums.EnvironmentId EnvironmentId { get; set; }

    }
}
