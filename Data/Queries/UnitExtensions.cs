using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class UnitExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Unit GetByKey(this IQueryable<Sca.Data.Entities.Unit> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Unit> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Unit> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Unit> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Unit> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
