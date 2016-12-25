using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class OrderDetail:EntityBase
    {
        public long? SpecialOfferID { get; set; }
        public long? ProductID { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public int? OrderQty { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? UnitPriceDiscount { get; set; }
        public Decimal? LineTotal { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid RowGuid { get; set; }
        public object OrderDetailID { get; set; }
    }
}
