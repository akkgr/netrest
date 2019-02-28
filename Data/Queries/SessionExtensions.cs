using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class SessionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Session GetByKey(this IQueryable<Sca.Data.Entities.Session> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Session> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Session> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Session> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Session> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Session> ByClientId(this IQueryable<Sca.Data.Entities.Session> queryable, int clientId)
        {
            return queryable.Where(q => q.ClientId == clientId);
        }

        public static IQueryable<Sca.Data.Entities.Session> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Session> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.Session> ByUserId(this IQueryable<Sca.Data.Entities.Session> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
