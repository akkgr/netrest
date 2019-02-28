using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ClientStatusesExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.ClientStatuses GetByKey(this IQueryable<Sca.Data.Entities.ClientStatuses> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ClientStatuses> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.ClientStatuses> GetByKeyAsync(this IQueryable<Sca.Data.Entities.ClientStatuses> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ClientStatuses> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
