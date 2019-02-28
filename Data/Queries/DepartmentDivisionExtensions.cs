using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DepartmentDivisionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DepartmentDivision GetByKey(this IQueryable<Sca.Data.Entities.DepartmentDivision> queryable, int departmentId, int divisionId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DepartmentDivision> dbSet)
                return dbSet.Find(departmentId, divisionId);

            return queryable.FirstOrDefault(q => q.DepartmentId == departmentId
                && q.DivisionId == divisionId);
        }

        public static Task<Sca.Data.Entities.DepartmentDivision> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DepartmentDivision> queryable, int departmentId, int divisionId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DepartmentDivision> dbSet)
                return dbSet.FindAsync(departmentId, divisionId);

            return queryable.FirstOrDefaultAsync(q => q.DepartmentId == departmentId
                && q.DivisionId == divisionId);
        }

        public static IQueryable<Sca.Data.Entities.DepartmentDivision> ByDepartmentId(this IQueryable<Sca.Data.Entities.DepartmentDivision> queryable, int departmentId)
        {
            return queryable.Where(q => q.DepartmentId == departmentId);
        }

        public static IQueryable<Sca.Data.Entities.DepartmentDivision> ByDivisionId(this IQueryable<Sca.Data.Entities.DepartmentDivision> queryable, int divisionId)
        {
            return queryable.Where(q => q.DivisionId == divisionId);
        }

        #endregion

    }
}
