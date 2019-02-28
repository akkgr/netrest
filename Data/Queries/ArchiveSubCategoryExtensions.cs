using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ArchiveSubCategoryExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.ArchiveSubCategory GetByKey(this IQueryable<Sca.Data.Entities.ArchiveSubCategory> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ArchiveSubCategory> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.ArchiveSubCategory> GetByKeyAsync(this IQueryable<Sca.Data.Entities.ArchiveSubCategory> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ArchiveSubCategory> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.ArchiveSubCategory> ByCategoryId(this IQueryable<Sca.Data.Entities.ArchiveSubCategory> queryable, int categoryId)
        {
            return queryable.Where(q => q.CategoryId == categoryId);
        }

        #endregion

    }
}
