using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DocRankExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DocRank GetByKey(this IQueryable<Sca.Data.Entities.DocRank> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DocRank> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.DocRank> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DocRank> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DocRank> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.DocRank GetByTitle(this IQueryable<Sca.Data.Entities.DocRank> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.DocRank> GetByTitleAsync(this IQueryable<Sca.Data.Entities.DocRank> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
