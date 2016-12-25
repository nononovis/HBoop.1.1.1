using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class Comment
    {
        public long CommentID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public long? BeneficiaryID { get; set; }
        public long? AffiliateID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
