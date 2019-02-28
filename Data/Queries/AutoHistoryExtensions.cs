using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AutoHistoryExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.AutoHistory GetByKey(this IQueryable<Sca.Data.Entities.AutoHistory> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AutoHistory> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.AutoHistory> GetByKeyAsync(this IQueryable<Sca.Data.Entities.AutoHistory> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AutoHistory> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
