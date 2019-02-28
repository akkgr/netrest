using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DocDocGroupExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DocDocGroup GetByKey(this IQueryable<Sca.Data.Entities.DocDocGroup> queryable, int docId, int groupId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DocDocGroup> dbSet)
                return dbSet.Find(docId, groupId);

            return queryable.FirstOrDefault(q => q.DocId == docId
                && q.GroupId == groupId);
        }

        public static Task<Sca.Data.Entities.DocDocGroup> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DocDocGroup> queryable, int docId, int groupId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DocDocGroup> dbSet)
                return dbSet.FindAsync(docId, groupId);

            return queryable.FirstOrDefaultAsync(q => q.DocId == docId
                && q.GroupId == groupId);
        }

        public static IQueryable<Sca.Data.Entities.DocDocGroup> ByGroupId(this IQueryable<Sca.Data.Entities.DocDocGroup> queryable, int groupId)
        {
            return queryable.Where(q => q.GroupId == groupId);
        }

        public static IQueryable<Sca.Data.Entities.DocDocGroup> ByDocId(this IQueryable<Sca.Data.Entities.DocDocGroup> queryable, int docId)
        {
            return queryable.Where(q => q.DocId == docId);
        }

        #endregion

    }
}
