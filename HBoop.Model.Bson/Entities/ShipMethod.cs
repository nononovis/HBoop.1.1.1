using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class ShipMethod:Entity
    {
        public string Name { get; set; }
        public Decimal? ShipBase { get; set; }
        public Decimal? ShipRate { get; set; }
    }
}
