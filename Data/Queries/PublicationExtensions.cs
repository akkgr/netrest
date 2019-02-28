using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class PublicationExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Publication GetByKey(this IQueryable<Sca.Data.Entities.Publication> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Publication> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Publication> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Publication> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Publication> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Publication> ByRankId(this IQueryable<Sca.Data.Entities.Publication> queryable, int rankId)
        {
            return queryable.Where(q => q.RankId == rankId);
        }

        #endregion

    }
}
