using HBoop.Models;
using Microsoft.EntityFrameworkCore;

namespace HBoop.DataAccess.Mapping
{
    public class AddressMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Address>();
            entity.ToTable("Address", "Address");
            entity.HasKey(p => p.AddressID);
            entity.Property(p => p.AddressID).UseSqlServerIdentityColumn();
        }
    }
}
