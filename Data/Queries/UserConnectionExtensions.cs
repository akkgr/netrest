using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class UserConnectionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.UserConnection GetByKey(this IQueryable<Sca.Data.Entities.UserConnection> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserConnection> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.UserConnection> GetByKeyAsync(this IQueryable<Sca.Data.Entities.UserConnection> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserConnection> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
