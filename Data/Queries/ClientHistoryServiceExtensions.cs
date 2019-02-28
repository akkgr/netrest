using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ClientHistoryServiceExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.ClientHistoryService GetByKey(this IQueryable<Sca.Data.Entities.ClientHistoryService> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ClientHistoryService> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.ClientHistoryService> GetByKeyAsync(this IQueryable<Sca.Data.Entities.ClientHistoryService> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ClientHistoryService> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.ClientHistoryService> ByClientHistoryId(this IQueryable<Sca.Data.Entities.ClientHistoryService> queryable, int clientHistoryId)
        {
            return queryable.Where(q => q.ClientHistoryId == clientHistoryId);
        }

        public static IQueryable<Sca.Data.Entities.ClientHistoryService> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.ClientHistoryService> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        #endregion

    }
}
