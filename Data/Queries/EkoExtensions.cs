using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class EkoExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Eko GetByKey(this IQueryable<Sca.Data.Entities.Eko> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Eko> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Eko> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Eko> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Eko> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Eko GetByTitle(this IQueryable<Sca.Data.Entities.Eko> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.Eko> GetByTitleAsync(this IQueryable<Sca.Data.Entities.Eko> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
