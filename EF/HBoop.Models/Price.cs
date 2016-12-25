using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class Price:EntityBase
    {
        public Decimal? UnitPrice { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Guid RowGuid { get; set; }
    }
}
