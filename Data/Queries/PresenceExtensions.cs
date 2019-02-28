using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class PresenceExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Presence GetByKey(this IQueryable<Sca.Data.Entities.Presence> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Presence> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Presence> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Presence> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Presence> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Presence GetByEmployeeIdEntryTime(this IQueryable<Sca.Data.Entities.Presence> queryable, int employeeId, DateTime entryTime)
        {
            return queryable.FirstOrDefault(q => q.EmployeeId == employeeId
                && q.EntryTime == entryTime);
        }

        public static Task<Sca.Data.Entities.Presence> GetByEmployeeIdEntryTimeAsync(this IQueryable<Sca.Data.Entities.Presence> queryable, int employeeId, DateTime entryTime)
        {
            return queryable.FirstOrDefaultAsync(q => q.EmployeeId == employeeId
                && q.EntryTime == entryTime);
        }

        public static IQueryable<Sca.Data.Entities.Presence> ByEmployeeId(this IQueryable<Sca.Data.Entities.Presence> queryable, int employeeId)
        {
            return queryable.Where(q => q.EmployeeId == employeeId);
        }

        public static IQueryable<Sca.Data.Entities.Presence> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Presence> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        #endregion

    }
}
