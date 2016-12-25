using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class Order:EntityBase
    {
        public long? AffiliateID { get; set; }
        public long? CreditCardID { get; set; }
        public long? CurrencyRateID { get; set; }
        public Decimal? SubTotal { get; set; }
        public Decimal? TaxAmt { get; set; }
        public Decimal? Freight { get; set; }
        public Decimal? Total { get; set; }
        public string Comment { get; set; }
        public int? Status { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }

        public Guid RowGuid { get; set; }
        public object OrderID { get; set; }
    }
}
