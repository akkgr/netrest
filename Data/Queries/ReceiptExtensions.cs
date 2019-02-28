using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ReceiptExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Receipt GetByKey(this IQueryable<Sca.Data.Entities.Receipt> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Receipt> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Receipt> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Receipt> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Receipt> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Receipt> ByRankId(this IQueryable<Sca.Data.Entities.Receipt> queryable, int rankId)
        {
            return queryable.Where(q => q.RankId == rankId);
        }

        public static IQueryable<Sca.Data.Entities.Receipt> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Receipt> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.Receipt> ByUserId(this IQueryable<Sca.Data.Entities.Receipt> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
