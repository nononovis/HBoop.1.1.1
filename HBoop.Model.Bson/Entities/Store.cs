using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Store : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public Address Address { get; set; }
    }
}
