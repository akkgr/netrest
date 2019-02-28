using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class IncomeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Income GetByKey(this IQueryable<Sca.Data.Entities.Income> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Income> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Income> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Income> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Income> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Income GetByTitle(this IQueryable<Sca.Data.Entities.Income> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.Income> GetByTitleAsync(this IQueryable<Sca.Data.Entities.Income> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
