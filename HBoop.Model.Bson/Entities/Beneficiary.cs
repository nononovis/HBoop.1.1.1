using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Beneficiary:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public TypeEntity BeneficiaryType { get; set; }
        public Person Person { get; set; }
        public ICollection<Address> Address { get; set; }
        public User User { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
