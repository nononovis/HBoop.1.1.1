using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class AffiliateType:EntityBase
    {
        public long AffiliateTypeID { get; set; }

        public Guid RowGuid { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Code { get; set; }
    }
}
