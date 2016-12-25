using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Model.Bson.Entities
{
    public class Person:Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Civility { get; set; }
        public DateTime? BirthDate { get; set; }
        public String BirthCountry { get; set; }
    }
}
