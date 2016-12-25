using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class Media:EntityBase
    {
        public long MediaID { get; set; }

        public Boolean IsDeleted { get; set; }

        public long? MediaTypeID { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string Description { get; set; }

        public MediaType MediaTypeFK { get; set; }

        public Guid RowGuid { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
