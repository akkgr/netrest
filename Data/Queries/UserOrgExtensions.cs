using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class UserOrgExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.UserOrg GetByKey(this IQueryable<Sca.Data.Entities.UserOrg> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserOrg> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.UserOrg> GetByKeyAsync(this IQueryable<Sca.Data.Entities.UserOrg> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserOrg> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.UserOrg GetByUserIdOrgTreeNodeId(this IQueryable<Sca.Data.Entities.UserOrg> queryable, int userId, int orgTreeNodeId)
        {
            return queryable.FirstOrDefault(q => q.UserId == userId
                && q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static Task<Sca.Data.Entities.UserOrg> GetByUserIdOrgTreeNodeIdAsync(this IQueryable<Sca.Data.Entities.UserOrg> queryable, int userId, int orgTreeNodeId)
        {
            return queryable.FirstOrDefaultAsync(q => q.UserId == userId
                && q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.UserOrg> ByUserId(this IQueryable<Sca.Data.Entities.UserOrg> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static IQueryable<Sca.Data.Entities.UserOrg> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.UserOrg> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        #endregion

    }
}
