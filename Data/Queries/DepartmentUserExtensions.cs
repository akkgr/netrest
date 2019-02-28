using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DepartmentUserExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DepartmentUser GetByKey(this IQueryable<Sca.Data.Entities.DepartmentUser> queryable, int departmentId, int userId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DepartmentUser> dbSet)
                return dbSet.Find(departmentId, userId);

            return queryable.FirstOrDefault(q => q.DepartmentId == departmentId
                && q.UserId == userId);
        }

        public static Task<Sca.Data.Entities.DepartmentUser> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DepartmentUser> queryable, int departmentId, int userId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DepartmentUser> dbSet)
                return dbSet.FindAsync(departmentId, userId);

            return queryable.FirstOrDefaultAsync(q => q.DepartmentId == departmentId
                && q.UserId == userId);
        }

        public static IQueryable<Sca.Data.Entities.DepartmentUser> ByDepartmentId(this IQueryable<Sca.Data.Entities.DepartmentUser> queryable, int departmentId)
        {
            return queryable.Where(q => q.DepartmentId == departmentId);
        }

        public static IQueryable<Sca.Data.Entities.DepartmentUser> ByUserId(this IQueryable<Sca.Data.Entities.DepartmentUser> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
