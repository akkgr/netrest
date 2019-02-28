using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CountyExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.County GetByKey(this IQueryable<Sca.Data.Entities.County> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.County> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.County> GetByKeyAsync(this IQueryable<Sca.Data.Entities.County> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.County> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
