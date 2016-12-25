using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HBoop.DataAccess.Mapping
{
    public class EntityMapper : IEntityMapper
    {
        public IEnumerable<IEntityMap> Mappings
        {
            get;protected set;
        }

        public void MapEntities(ModelBuilder modelBuilder)
        {
            foreach (var map in Mappings)
            {
                map.Map(modelBuilder);
            }
        }
    }
}
