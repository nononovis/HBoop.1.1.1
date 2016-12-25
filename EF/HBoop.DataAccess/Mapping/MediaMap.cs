using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HBoop.Models;

namespace HBoop.DataAccess.Mapping
{
    public class MediaMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Media>();
            entity.ToTable("Media", "Media");
            entity.HasKey(p => p.MediaID);
            entity.Property(p => p.MediaID).UseSqlServerIdentityColumn();
        }
    }
}
