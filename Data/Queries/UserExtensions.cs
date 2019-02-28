using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class UserExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.User GetByKey(this IQueryable<Sca.Data.Entities.User> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.User> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.User> GetByKeyAsync(this IQueryable<Sca.Data.Entities.User> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.User> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.User GetByUserName(this IQueryable<Sca.Data.Entities.User> queryable, string userName)
        {
            return queryable.FirstOrDefault(q => q.UserName == userName);
        }

        public static Task<Sca.Data.Entities.User> GetByUserNameAsync(this IQueryable<Sca.Data.Entities.User> queryable, string userName)
        {
            return queryable.FirstOrDefaultAsync(q => q.UserName == userName);
        }

        public static Sca.Data.Entities.User GetByFullName(this IQueryable<Sca.Data.Entities.User> queryable, string fullName)
        {
            return queryable.FirstOrDefault(q => q.FullName == fullName);
        }

        public static Task<Sca.Data.Entities.User> GetByFullNameAsync(this IQueryable<Sca.Data.Entities.User> queryable, string fullName)
        {
            return queryable.FirstOrDefaultAsync(q => q.FullName == fullName);
        }

        public static IQueryable<Sca.Data.Entities.User> BySecRank(this IQueryable<Sca.Data.Entities.User> queryable, int? secRank)
        {
            return queryable.Where(q => (q.SecRank == secRank || (secRank == null && q.SecRank == null)));
        }

        public static IQueryable<Sca.Data.Entities.User> ByEmployeeId(this IQueryable<Sca.Data.Entities.User> queryable, int? employeeId)
        {
            return queryable.Where(q => (q.EmployeeId == employeeId || (employeeId == null && q.EmployeeId == null)));
        }

        #endregion

    }
}
