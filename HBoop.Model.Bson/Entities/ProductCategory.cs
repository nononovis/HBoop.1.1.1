using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class ProductCategory:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public Media LogoPicture { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
