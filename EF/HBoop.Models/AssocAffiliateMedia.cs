using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class AssocAffiliateMedia
    {
        public long AssocAffiliateMediaID { get; set; }
        public long? AffiliateID { get; set; }
        public long? MediaID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
