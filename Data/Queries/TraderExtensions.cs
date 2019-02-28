using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class TraderExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Trader GetByKey(this IQueryable<Sca.Data.Entities.Trader> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Trader> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Trader> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Trader> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Trader> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Trader GetByBarCode(this IQueryable<Sca.Data.Entities.Trader> queryable, string barCode)
        {
            return queryable.FirstOrDefault(q => (q.BarCode == barCode || (barCode == null && q.BarCode == null)));
        }

        public static Task<Sca.Data.Entities.Trader> GetByBarCodeAsync(this IQueryable<Sca.Data.Entities.Trader> queryable, string barCode)
        {
            return queryable.FirstOrDefaultAsync(q => (q.BarCode == barCode || (barCode == null && q.BarCode == null)));
        }

        public static IQueryable<Sca.Data.Entities.Trader> ByRankId(this IQueryable<Sca.Data.Entities.Trader> queryable, int? rankId)
        {
            return queryable.Where(q => (q.RankId == rankId || (rankId == null && q.RankId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Trader> ByDOYId(this IQueryable<Sca.Data.Entities.Trader> queryable, int? dOYId)
        {
            return queryable.Where(q => (q.DOYId == dOYId || (dOYId == null && q.DOYId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Trader> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Trader> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Trader> ByUserId(this IQueryable<Sca.Data.Entities.Trader> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
