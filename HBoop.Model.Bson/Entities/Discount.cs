using System;

namespace HBoop.Model.Bson.Entities
{
    public class Discount:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public Decimal Rate { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? DateFrom { get; set; }

    }
}
