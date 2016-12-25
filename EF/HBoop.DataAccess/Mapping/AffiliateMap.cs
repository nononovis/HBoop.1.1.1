using HBoop.Models;
using Microsoft.EntityFrameworkCore;

namespace HBoop.DataAccess.Mapping
{
    public class AffiliateMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Affiliate>();
            entity.ToTable("Affiliate", "Affiliate");
            entity.HasKey(p => p.AffiliateID);
            entity.Property(p => p.AffiliateID).UseSqlServerIdentityColumn();
        }
    }
}
