using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Comment:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Beneficiary Beneficiary { get; set; }
        public Affiliate Affiliate { get; set; }
    }
}
