using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class BeneficiaryType
    {
        public long BeneficiaryTypeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
