using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class UserRoleExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.UserRole GetByKey(this IQueryable<Sca.Data.Entities.UserRole> queryable, int userId, int roleId)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserRole> dbSet)
                return dbSet.Find(userId, roleId);

            return queryable.FirstOrDefault(q => q.UserId == userId
                && q.RoleId == roleId);
        }

        public static Task<Sca.Data.Entities.UserRole> GetByKeyAsync(this IQueryable<Sca.Data.Entities.UserRole> queryable, int userId, int roleId)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserRole> dbSet)
                return dbSet.FindAsync(userId, roleId);

            return queryable.FirstOrDefaultAsync(q => q.UserId == userId
                && q.RoleId == roleId);
        }

        public static IQueryable<Sca.Data.Entities.UserRole> ByRoleId(this IQueryable<Sca.Data.Entities.UserRole> queryable, int roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        public static IQueryable<Sca.Data.Entities.UserRole> ByUserId(this IQueryable<Sca.Data.Entities.UserRole> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
