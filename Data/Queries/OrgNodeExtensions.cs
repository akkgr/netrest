using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class OrgNodeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.OrgNode GetByKey(this IQueryable<Sca.Data.Entities.OrgNode> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.OrgNode> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.OrgNode> GetByKeyAsync(this IQueryable<Sca.Data.Entities.OrgNode> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.OrgNode> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.OrgNode GetByCode(this IQueryable<Sca.Data.Entities.OrgNode> queryable, string code)
        {
            return queryable.FirstOrDefault(q => q.Code == code);
        }

        public static Task<Sca.Data.Entities.OrgNode> GetByCodeAsync(this IQueryable<Sca.Data.Entities.OrgNode> queryable, string code)
        {
            return queryable.FirstOrDefaultAsync(q => q.Code == code);
        }

        public static IQueryable<Sca.Data.Entities.OrgNode> ByNodeTypeId(this IQueryable<Sca.Data.Entities.OrgNode> queryable, int nodeTypeId)
        {
            return queryable.Where(q => q.NodeTypeId == nodeTypeId);
        }

        #endregion

    }
}
