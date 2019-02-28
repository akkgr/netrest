using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class EmployeeIntakeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.EmployeeIntake GetByKey(this IQueryable<Sca.Data.Entities.EmployeeIntake> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.EmployeeIntake> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.EmployeeIntake> GetByKeyAsync(this IQueryable<Sca.Data.Entities.EmployeeIntake> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.EmployeeIntake> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.EmployeeIntake> ByEmployeeId(this IQueryable<Sca.Data.Entities.EmployeeIntake> queryable, int employeeId)
        {
            return queryable.Where(q => q.EmployeeId == employeeId);
        }

        public static IQueryable<Sca.Data.Entities.EmployeeIntake> ByIntakeId(this IQueryable<Sca.Data.Entities.EmployeeIntake> queryable, int intakeId)
        {
            return queryable.Where(q => q.IntakeId == intakeId);
        }

        public static IQueryable<Sca.Data.Entities.EmployeeIntake> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.EmployeeIntake> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        #endregion

    }
}
