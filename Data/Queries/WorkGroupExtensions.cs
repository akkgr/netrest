using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class WorkGroupExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.WorkGroup GetByKey(this IQueryable<Sca.Data.Entities.WorkGroup> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.WorkGroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.WorkGroup> GetByKeyAsync(this IQueryable<Sca.Data.Entities.WorkGroup> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.WorkGroup> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.WorkGroup> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.WorkGroup> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.WorkGroup> ByUserId(this IQueryable<Sca.Data.Entities.WorkGroup> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static IQueryable<Sca.Data.Entities.WorkGroup> ByWorkGroupTypeId(this IQueryable<Sca.Data.Entities.WorkGroup> queryable, int? workGroupTypeId)
        {
            return queryable.Where(q => (q.WorkGroupTypeId == workGroupTypeId || (workGroupTypeId == null && q.WorkGroupTypeId == null)));
        }

        #endregion

    }
}
