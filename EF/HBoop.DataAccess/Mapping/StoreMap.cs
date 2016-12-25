using HBoop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HBoop.DataAccess.Mapping
{
    public class StoreMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Store>();
            entity.ToTable("Store", "Store");
            entity.HasKey(p => p.StoreID);
            entity.Property(p => p.StoreID).UseSqlServerIdentityColumn();
        }
    }
}
