using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DocumentExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Document GetByKey(this IQueryable<Sca.Data.Entities.Document> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Document> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Document> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Document> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Document> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Document> ByRankId(this IQueryable<Sca.Data.Entities.Document> queryable, int? rankId)
        {
            return queryable.Where(q => (q.RankId == rankId || (rankId == null && q.RankId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Document> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Document> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Document> ByUserId(this IQueryable<Sca.Data.Entities.Document> queryable, int? userId)
        {
            return queryable.Where(q => (q.UserId == userId || (userId == null && q.UserId == null)));
        }

        #endregion

    }
}
