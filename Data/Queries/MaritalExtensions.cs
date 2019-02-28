using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class MaritalExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Marital GetByKey(this IQueryable<Sca.Data.Entities.Marital> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Marital> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Marital> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Marital> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Marital> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Marital GetByTitle(this IQueryable<Sca.Data.Entities.Marital> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.Marital> GetByTitleAsync(this IQueryable<Sca.Data.Entities.Marital> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
