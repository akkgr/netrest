using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class NationalityExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Nationality GetByKey(this IQueryable<Sca.Data.Entities.Nationality> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Nationality> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Nationality> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Nationality> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Nationality> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Nationality GetByTitle(this IQueryable<Sca.Data.Entities.Nationality> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.Nationality> GetByTitleAsync(this IQueryable<Sca.Data.Entities.Nationality> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
