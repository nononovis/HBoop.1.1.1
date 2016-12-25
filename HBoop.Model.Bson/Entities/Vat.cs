using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Vat:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal? Rate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
