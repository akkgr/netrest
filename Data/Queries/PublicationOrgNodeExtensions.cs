using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class PublicationOrgNodeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.PublicationOrgNode GetByKey(this IQueryable<Sca.Data.Entities.PublicationOrgNode> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.PublicationOrgNode> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.PublicationOrgNode> GetByKeyAsync(this IQueryable<Sca.Data.Entities.PublicationOrgNode> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.PublicationOrgNode> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.PublicationOrgNode GetByPublicationIdOrgNodeId(this IQueryable<Sca.Data.Entities.PublicationOrgNode> queryable, int publicationId, int orgNodeId)
        {
            return queryable.FirstOrDefault(q => q.PublicationId == publicationId
                && q.OrgNodeId == orgNodeId);
        }

        public static Task<Sca.Data.Entities.PublicationOrgNode> GetByPublicationIdOrgNodeIdAsync(this IQueryable<Sca.Data.Entities.PublicationOrgNode> queryable, int publicationId, int orgNodeId)
        {
            return queryable.FirstOrDefaultAsync(q => q.PublicationId == publicationId
                && q.OrgNodeId == orgNodeId);
        }

        public static IQueryable<Sca.Data.Entities.PublicationOrgNode> ByOrgNodeId(this IQueryable<Sca.Data.Entities.PublicationOrgNode> queryable, int orgNodeId)
        {
            return queryable.Where(q => q.OrgNodeId == orgNodeId);
        }

        public static IQueryable<Sca.Data.Entities.PublicationOrgNode> ByPublicationId(this IQueryable<Sca.Data.Entities.PublicationOrgNode> queryable, int publicationId)
        {
            return queryable.Where(q => q.PublicationId == publicationId);
        }

        #endregion

    }
}
