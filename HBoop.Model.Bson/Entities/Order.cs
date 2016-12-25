using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Order:Entity
    {
        public CreditCard CreditCard { get; set; }
        public long? CurrencyRateID { get; set; }
        public Decimal? SubTotal { get; set; }
        public Decimal? TaxAmt { get; set; }
        public Decimal? Freight { get; set; }
        public Decimal? Total { get; set; }
        public string Comment { get; set; }
        public int? Status { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
