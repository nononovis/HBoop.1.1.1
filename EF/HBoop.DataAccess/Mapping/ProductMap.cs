using HBoop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HBoop.DataAccess.Mapping
{
    public class ProductMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Product>();
            entity.ToTable("Product", "Product");
            entity.HasKey(p => p.ProductID);
            entity.Property(p => p.ProductID).UseSqlServerIdentityColumn();
        }
    }
}
