using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DocGroupExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DocGroup GetByKey(this IQueryable<Sca.Data.Entities.DocGroup> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DocGroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.DocGroup> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DocGroup> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DocGroup> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.DocGroup GetByTitle(this IQueryable<Sca.Data.Entities.DocGroup> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.DocGroup> GetByTitleAsync(this IQueryable<Sca.Data.Entities.DocGroup> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
