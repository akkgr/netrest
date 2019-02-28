using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class RequestExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Request GetByKey(this IQueryable<Sca.Data.Entities.Request> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Request> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Request> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Request> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Request> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Request> ByAssignmentId(this IQueryable<Sca.Data.Entities.Request> queryable, int? assignmentId)
        {
            return queryable.Where(q => (q.AssignmentId == assignmentId || (assignmentId == null && q.AssignmentId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Request> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Request> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.Request> ByRequestTypeId(this IQueryable<Sca.Data.Entities.Request> queryable, int requestTypeId)
        {
            return queryable.Where(q => q.RequestTypeId == requestTypeId);
        }

        public static IQueryable<Sca.Data.Entities.Request> ByEmployeeId(this IQueryable<Sca.Data.Entities.Request> queryable, int employeeId)
        {
            return queryable.Where(q => q.EmployeeId == employeeId);
        }

        public static IQueryable<Sca.Data.Entities.Request> ByApprovedById(this IQueryable<Sca.Data.Entities.Request> queryable, int? approvedById)
        {
            return queryable.Where(q => (q.ApprovedById == approvedById || (approvedById == null && q.ApprovedById == null)));
        }

        #endregion

    }
}
