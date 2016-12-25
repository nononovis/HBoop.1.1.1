using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.Models
{
    public class Notification:EntityBase
    {
        public long NotificationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid RowGuid { get; set; }
    }
}
