using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class BoardMinuteExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.BoardMinute GetByKey(this IQueryable<Sca.Data.Entities.BoardMinute> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.BoardMinute> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.BoardMinute> GetByKeyAsync(this IQueryable<Sca.Data.Entities.BoardMinute> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.BoardMinute> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.BoardMinute> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.BoardMinute> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        #endregion

    }
}
