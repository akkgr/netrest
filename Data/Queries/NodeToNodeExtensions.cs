using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class NodeToNodeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.NodeToNode GetByKey(this IQueryable<Sca.Data.Entities.NodeToNode> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.NodeToNode> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.NodeToNode> GetByKeyAsync(this IQueryable<Sca.Data.Entities.NodeToNode> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.NodeToNode> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.NodeToNode> ByParentNode(this IQueryable<Sca.Data.Entities.NodeToNode> queryable, int parentNode)
        {
            return queryable.Where(q => q.ParentNode == parentNode);
        }

        public static IQueryable<Sca.Data.Entities.NodeToNode> ByChildNode(this IQueryable<Sca.Data.Entities.NodeToNode> queryable, int childNode)
        {
            return queryable.Where(q => q.ChildNode == childNode);
        }

        public static IQueryable<Sca.Data.Entities.NodeToNode> ByUserId(this IQueryable<Sca.Data.Entities.NodeToNode> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
