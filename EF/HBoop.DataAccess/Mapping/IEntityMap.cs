using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HBoop.DataAccess.Mapping
{
    public interface IEntityMap
    {
        void Map(ModelBuilder modelBuilder);
    }
}
