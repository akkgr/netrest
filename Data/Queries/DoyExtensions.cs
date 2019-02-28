using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DoyExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Doy GetByKey(this IQueryable<Sca.Data.Entities.Doy> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Doy> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Doy> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Doy> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Doy> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Doy GetByTitle(this IQueryable<Sca.Data.Entities.Doy> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.Doy> GetByTitleAsync(this IQueryable<Sca.Data.Entities.Doy> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
