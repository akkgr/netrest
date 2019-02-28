using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class InsurerExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Insurer GetByKey(this IQueryable<Sca.Data.Entities.Insurer> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Insurer> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Insurer> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Insurer> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Insurer> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Insurer GetByTitle(this IQueryable<Sca.Data.Entities.Insurer> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.Insurer> GetByTitleAsync(this IQueryable<Sca.Data.Entities.Insurer> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
