using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class OrderDetail:Entity
    {
        public long? SpecialOfferID { get; set; }
        public Product Product { get; set; }
        public int? OrderQty { get; set; }
        public Decimal? UnitPrice { get; set; }
        public Decimal? UnitPriceDiscount { get; set; }
        public Decimal? LineTotal { get; set; }
    }
}
