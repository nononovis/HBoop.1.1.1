using HBoop.Models;
using Microsoft.EntityFrameworkCore;

namespace HBoop.DataAccess.Mapping
{
    public class NotificationMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Notification>();
            entity.ToTable("Notification", "Notification");
            entity.HasKey(p => p.NotificationID);
            entity.Property(p => p.NotificationID).UseSqlServerIdentityColumn();
        }
    }
}
