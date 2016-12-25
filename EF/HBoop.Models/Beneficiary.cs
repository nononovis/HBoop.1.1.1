using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class Beneficiary
    {
        public long BeneficiaryID { get; set; }
        public  long? BeneficiaryTypeID { get; set; }
        public long? PersonID { get; set; }
        public long? BillToAddressID { get; set; }
        public long? ShipToAddressID { get; set; }
        public long? CreditCardID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
