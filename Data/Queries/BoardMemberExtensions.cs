using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class BoardMemberExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.BoardMember GetByKey(this IQueryable<Sca.Data.Entities.BoardMember> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.BoardMember> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.BoardMember> GetByKeyAsync(this IQueryable<Sca.Data.Entities.BoardMember> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.BoardMember> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.BoardMember> ByPosition(this IQueryable<Sca.Data.Entities.BoardMember> queryable, int position)
        {
            return queryable.Where(q => q.Position == position);
        }

        public static IQueryable<Sca.Data.Entities.BoardMember> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.BoardMember> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        #endregion

    }
}
