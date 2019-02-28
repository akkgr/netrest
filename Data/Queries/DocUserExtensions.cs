using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DocUserExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DocUser GetByKey(this IQueryable<Sca.Data.Entities.DocUser> queryable, int docId, int userId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DocUser> dbSet)
                return dbSet.Find(docId, userId);

            return queryable.FirstOrDefault(q => q.DocId == docId
                && q.UserId == userId);
        }

        public static Task<Sca.Data.Entities.DocUser> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DocUser> queryable, int docId, int userId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DocUser> dbSet)
                return dbSet.FindAsync(docId, userId);

            return queryable.FirstOrDefaultAsync(q => q.DocId == docId
                && q.UserId == userId);
        }

        public static IQueryable<Sca.Data.Entities.DocUser> ByDocId(this IQueryable<Sca.Data.Entities.DocUser> queryable, int docId)
        {
            return queryable.Where(q => q.DocId == docId);
        }

        public static IQueryable<Sca.Data.Entities.DocUser> ByUserId(this IQueryable<Sca.Data.Entities.DocUser> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
