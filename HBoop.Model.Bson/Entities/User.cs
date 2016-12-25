using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class User:Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public Role Role { get; set; }
        public TypeEntity ConnexionType { get; set; }
        public int? Status { get; set; }
    }
}
