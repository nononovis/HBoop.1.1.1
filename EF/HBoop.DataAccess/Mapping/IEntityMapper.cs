using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBoop.DataAccess.Mapping
{
   public interface IEntityMapper
    {
        IEnumerable<IEntityMap> Mappings { get; }
        void MapEntities(ModelBuilder modelBuilder);
    }
}
