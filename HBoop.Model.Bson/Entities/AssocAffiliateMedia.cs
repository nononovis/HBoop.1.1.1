using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class AssocAffiliateMedia:Entity
    {
        public long AssocAffiliateMediaID { get; set; }
        public long? AffiliateID { get; set; }
        public long? MediaID { get; set; }
    }
}
