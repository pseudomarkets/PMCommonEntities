﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class Orders
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string TransactionID { get; set; }
        public RDSEnums.OriginId OriginId { get; set; }
        public RDSEnums.SecurityType SecurityTypeId { get; set; }
        public RDSEnums.EnvironmentId EnvironmentId { get; set; }
    }
}
