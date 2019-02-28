using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class EmploymentTypeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.EmploymentType GetByKey(this IQueryable<Sca.Data.Entities.EmploymentType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.EmploymentType> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.EmploymentType> GetByKeyAsync(this IQueryable<Sca.Data.Entities.EmploymentType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.EmploymentType> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.EmploymentType GetByTitle(this IQueryable<Sca.Data.Entities.EmploymentType> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.EmploymentType> GetByTitleAsync(this IQueryable<Sca.Data.Entities.EmploymentType> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
