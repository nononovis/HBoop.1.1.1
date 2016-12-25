using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Product:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Media LogoPicture { get; set; }
        public Price Price { get; set; }
        public Discount Discount { get; set; }
        public Time Time { get; set; }
        public int? Status { get; set; }
        public TypeEntity Genre { get; set; }
        public ProductCategory Category { get; set; }
    }
}
