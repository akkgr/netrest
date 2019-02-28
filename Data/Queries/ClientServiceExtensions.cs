using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ClientServiceExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.ClientService GetByKey(this IQueryable<Sca.Data.Entities.ClientService> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ClientService> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.ClientService> GetByKeyAsync(this IQueryable<Sca.Data.Entities.ClientService> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ClientService> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.ClientService> ByClientId(this IQueryable<Sca.Data.Entities.ClientService> queryable, int clientId)
        {
            return queryable.Where(q => q.ClientId == clientId);
        }

        public static IQueryable<Sca.Data.Entities.ClientService> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.ClientService> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        #endregion

    }
}
