using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class OrgTreeNodeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.OrgTreeNode GetByKey(this IQueryable<Sca.Data.Entities.OrgTreeNode> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.OrgTreeNode> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.OrgTreeNode> GetByKeyAsync(this IQueryable<Sca.Data.Entities.OrgTreeNode> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.OrgTreeNode> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.OrgTreeNode GetByCode(this IQueryable<Sca.Data.Entities.OrgTreeNode> queryable, string code)
        {
            return queryable.FirstOrDefault(q => q.Code == code);
        }

        public static Task<Sca.Data.Entities.OrgTreeNode> GetByCodeAsync(this IQueryable<Sca.Data.Entities.OrgTreeNode> queryable, string code)
        {
            return queryable.FirstOrDefaultAsync(q => q.Code == code);
        }

        public static IQueryable<Sca.Data.Entities.OrgTreeNode> ByNodeId(this IQueryable<Sca.Data.Entities.OrgTreeNode> queryable, int nodeId)
        {
            return queryable.Where(q => q.NodeId == nodeId);
        }

        public static IQueryable<Sca.Data.Entities.OrgTreeNode> ByParentId(this IQueryable<Sca.Data.Entities.OrgTreeNode> queryable, int? parentId)
        {
            return queryable.Where(q => (q.ParentId == parentId || (parentId == null && q.ParentId == null)));
        }

        #endregion

    }
}
