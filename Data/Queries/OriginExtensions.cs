using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class OriginExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Origin GetByKey(this IQueryable<Sca.Data.Entities.Origin> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Origin> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Origin> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Origin> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Origin> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
