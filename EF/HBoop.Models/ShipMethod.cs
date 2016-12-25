using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class ShipMethod:EntityBase
    {
        public long ShipMethodID { get; set; }
        public string Name { get; set; }
        public Decimal? ShipBase { get; set; }
        public Decimal? ShipRate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
