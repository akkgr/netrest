using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class UserDivisionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.UserDivision GetByKey(this IQueryable<Sca.Data.Entities.UserDivision> queryable, int userId, int divisionId)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserDivision> dbSet)
                return dbSet.Find(userId, divisionId);

            return queryable.FirstOrDefault(q => q.UserId == userId
                && q.DivisionId == divisionId);
        }

        public static Task<Sca.Data.Entities.UserDivision> GetByKeyAsync(this IQueryable<Sca.Data.Entities.UserDivision> queryable, int userId, int divisionId)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserDivision> dbSet)
                return dbSet.FindAsync(userId, divisionId);

            return queryable.FirstOrDefaultAsync(q => q.UserId == userId
                && q.DivisionId == divisionId);
        }

        public static IQueryable<Sca.Data.Entities.UserDivision> ByDivisionId(this IQueryable<Sca.Data.Entities.UserDivision> queryable, int divisionId)
        {
            return queryable.Where(q => q.DivisionId == divisionId);
        }

        public static IQueryable<Sca.Data.Entities.UserDivision> ByUserId(this IQueryable<Sca.Data.Entities.UserDivision> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
