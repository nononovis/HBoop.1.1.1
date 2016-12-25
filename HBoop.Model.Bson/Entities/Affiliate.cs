using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Affiliate:Entity
    {
        public Store  Store { get; set; }
        public TypeEntity AffiliateType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
