using HBoop.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HBoop.DataAccess.Mapping
{
    public class BeneficiaryMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Beneficiary>();
            entity.ToTable("Beneficiary", "Beneficiary");
            entity.HasKey(p => p.BeneficiaryID);
            entity.Property(p => p.BeneficiaryID).UseSqlServerIdentityColumn();
        }

    }
}
