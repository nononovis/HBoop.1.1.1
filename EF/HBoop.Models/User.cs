using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class User:EntityBase
    {
        public long UserID { get; set; }
        public string Login { get; set; }
        public string Mail { get; set; }
        public long? RoleID { get; set; }
        public int? Status { get; set; }
        public string Password { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
