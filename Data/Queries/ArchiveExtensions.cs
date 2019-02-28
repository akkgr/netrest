using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ArchiveExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Archive GetByKey(this IQueryable<Sca.Data.Entities.Archive> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Archive> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Archive> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Archive> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Archive> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Archive> ByCategoryId(this IQueryable<Sca.Data.Entities.Archive> queryable, int? categoryId)
        {
            return queryable.Where(q => (q.CategoryId == categoryId || (categoryId == null && q.CategoryId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Archive> BySubCategoryId(this IQueryable<Sca.Data.Entities.Archive> queryable, int? subCategoryId)
        {
            return queryable.Where(q => (q.SubCategoryId == subCategoryId || (subCategoryId == null && q.SubCategoryId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Archive> ByRankId(this IQueryable<Sca.Data.Entities.Archive> queryable, int? rankId)
        {
            return queryable.Where(q => (q.RankId == rankId || (rankId == null && q.RankId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Archive> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Archive> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Archive> ByUserId(this IQueryable<Sca.Data.Entities.Archive> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
