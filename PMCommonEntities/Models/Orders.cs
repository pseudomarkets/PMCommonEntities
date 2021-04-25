using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagePack;
using PMCommonEntities;
using PMCommonEntities.Models;

/*
 * Pseudo Markets Unified Web API
 * Orders Table Model for Entity Framework
 * Author: Shravan Jambukesan <shravan@shravanj.com>
 * (c) 2019 - 2020 Pseudo Markets
 */

namespace PMUnifiedAPI.Models
{
    [MessagePackObject]
    public class Orders
    {
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Symbol { get; set; }
        [Key(2)]
        public string Type { get; set; }
        [Key(3)]
        public double Price { get; set; }
        [Key(4)]
        public int Quantity { get; set; }
        [Key(5)]
        public DateTime Date { get; set; }
        [Key(6)]
        public string TransactionID { get; set; }
        [Key(7)]
        public RDSEnums.OriginId OriginId { get; set; }
        [Key(8)]
        public RDSEnums.SecurityType SecurityTypeId { get; set; }
        [Key(9)]
        public RDSEnums.EnvironmentId EnvironmentId { get; set; }
    }
}
