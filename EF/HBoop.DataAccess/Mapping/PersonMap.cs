using HBoop.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HBoop.DataAccess.Mapping
{
    public class PersonMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Person>();
            entity.ToTable("Person", "Person");
            entity.HasKey(p => p.PersonID);
            entity.Property(p => p.PersonID).UseSqlServerIdentityColumn();
        }
    }
}
