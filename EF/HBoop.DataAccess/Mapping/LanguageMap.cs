using HBoop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HBoop.DataAccess.Mapping
{
    public class LanguageMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Language>();
            entity.ToTable("Language", "Language");
            entity.HasKey(p => p.LanguageID);
            entity.Property(p => p.LanguageID).UseSqlServerIdentityColumn();
        }
    }
}
