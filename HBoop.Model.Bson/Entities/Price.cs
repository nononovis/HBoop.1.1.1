using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Price:Entity
    {
        public Decimal? UnitPrice { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
