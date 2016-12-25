using HBoop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HBoop.DataAccess.Mapping
{
    public class UserMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<User>();
            entity.ToTable("User", "User");
            entity.HasKey(p => p.UserID);
            entity.Property(p => p.UserID).UseSqlServerIdentityColumn();
        }
    }
}
