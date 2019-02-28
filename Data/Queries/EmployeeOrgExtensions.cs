using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class EmployeeOrgExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.EmployeeOrg GetByKey(this IQueryable<Sca.Data.Entities.EmployeeOrg> queryable, int orgTreeNodeId, int employeeId)
        {
            if (queryable is DbSet<Sca.Data.Entities.EmployeeOrg> dbSet)
                return dbSet.Find(orgTreeNodeId, employeeId);

            return queryable.FirstOrDefault(q => q.OrgTreeNodeId == orgTreeNodeId
                && q.EmployeeId == employeeId);
        }

        public static Task<Sca.Data.Entities.EmployeeOrg> GetByKeyAsync(this IQueryable<Sca.Data.Entities.EmployeeOrg> queryable, int orgTreeNodeId, int employeeId)
        {
            if (queryable is DbSet<Sca.Data.Entities.EmployeeOrg> dbSet)
                return dbSet.FindAsync(orgTreeNodeId, employeeId);

            return queryable.FirstOrDefaultAsync(q => q.OrgTreeNodeId == orgTreeNodeId
                && q.EmployeeId == employeeId);
        }

        public static IQueryable<Sca.Data.Entities.EmployeeOrg> ByEmployeeId(this IQueryable<Sca.Data.Entities.EmployeeOrg> queryable, int employeeId)
        {
            return queryable.Where(q => q.EmployeeId == employeeId);
        }

        public static IQueryable<Sca.Data.Entities.EmployeeOrg> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.EmployeeOrg> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        #endregion

    }
}
