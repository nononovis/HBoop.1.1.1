using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class MediaType:EntityBase
    {
        public long MediaTypeID { get; set; }
        public string Label { get; set; }
        public int Code { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
