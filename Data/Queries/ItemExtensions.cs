using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ItemExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Item GetByKey(this IQueryable<Sca.Data.Entities.Item> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Item> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Item> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Item> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Item> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Item GetByBarCode(this IQueryable<Sca.Data.Entities.Item> queryable, string barCode)
        {
            return queryable.FirstOrDefault(q => q.BarCode == barCode);
        }

        public static Task<Sca.Data.Entities.Item> GetByBarCodeAsync(this IQueryable<Sca.Data.Entities.Item> queryable, string barCode)
        {
            return queryable.FirstOrDefaultAsync(q => q.BarCode == barCode);
        }

        public static IQueryable<Sca.Data.Entities.Item> ByCategoryId(this IQueryable<Sca.Data.Entities.Item> queryable, int categoryId)
        {
            return queryable.Where(q => q.CategoryId == categoryId);
        }

        public static IQueryable<Sca.Data.Entities.Item> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Item> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Item> ByPackagingId(this IQueryable<Sca.Data.Entities.Item> queryable, int packagingId)
        {
            return queryable.Where(q => q.PackagingId == packagingId);
        }

        public static IQueryable<Sca.Data.Entities.Item> ByUnitId(this IQueryable<Sca.Data.Entities.Item> queryable, int unitId)
        {
            return queryable.Where(q => q.UnitId == unitId);
        }

        #endregion

    }
}
