using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class Store : EntityBase
    {
        public long StoreID { get; set; }
        public long? Longitude { get; set; }
        public long? Latitude { get; set; }
        public long ?AddressID { get; set; }
        public long? AffiliateType { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
