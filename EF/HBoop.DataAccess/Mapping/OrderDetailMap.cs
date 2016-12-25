using HBoop.DataAccess.Mapping;
using Microsoft.EntityFrameworkCore;

namespace HBoop.Models
{
    public class OrderDetailMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<OrderDetail>();
            entity.ToTable("OrderDetail", "OrderDetail");
            entity.HasKey(p => p.OrderDetailID);
            entity.Property(p => p.OrderDetailID).UseSqlServerIdentityColumn();
        }
    }
}
