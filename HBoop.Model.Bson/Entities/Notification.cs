using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Notification:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
