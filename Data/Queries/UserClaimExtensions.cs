using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class UserClaimExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.UserClaim GetByKey(this IQueryable<Sca.Data.Entities.UserClaim> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserClaim> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.UserClaim> GetByKeyAsync(this IQueryable<Sca.Data.Entities.UserClaim> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserClaim> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.UserClaim> ByUserId(this IQueryable<Sca.Data.Entities.UserClaim> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
