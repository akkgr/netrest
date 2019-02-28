using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class EducationExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Education GetByKey(this IQueryable<Sca.Data.Entities.Education> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Education> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Education> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Education> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Education> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Education GetByTitle(this IQueryable<Sca.Data.Entities.Education> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.Education> GetByTitleAsync(this IQueryable<Sca.Data.Entities.Education> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
