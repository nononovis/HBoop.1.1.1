using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Media:Entity
    {
        public int? Status { get; set; }

        public TypeEntity MediaType { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string Description { get; set; }
    }
}
