using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class SpecialtyExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Specialty GetByKey(this IQueryable<Sca.Data.Entities.Specialty> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Specialty> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Specialty> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Specialty> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Specialty> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Specialty GetByTitle(this IQueryable<Sca.Data.Entities.Specialty> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.Specialty> GetByTitleAsync(this IQueryable<Sca.Data.Entities.Specialty> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
