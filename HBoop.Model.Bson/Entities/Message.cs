using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Message:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
