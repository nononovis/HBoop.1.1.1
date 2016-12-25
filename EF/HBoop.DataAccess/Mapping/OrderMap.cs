using HBoop.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HBoop.DataAccess.Mapping
{
    public class OrderMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Order>();
            entity.ToTable("Order", "Order");
            entity.HasKey(p => p.OrderID);
            entity.Property(p => p.OrderID).UseSqlServerIdentityColumn();
        }
    }
}
