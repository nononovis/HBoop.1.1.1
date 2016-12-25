using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class ProductCategory:EntityBase
    {
        public long ProductCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
