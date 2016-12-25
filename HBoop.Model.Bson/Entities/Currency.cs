using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
     public  class Currency:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public string Code { get; set; }
    }
}
