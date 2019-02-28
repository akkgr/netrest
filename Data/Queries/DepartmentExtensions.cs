using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DepartmentExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Department GetByKey(this IQueryable<Sca.Data.Entities.Department> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Department> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Department> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Department> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Department> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Department> ByParentId(this IQueryable<Sca.Data.Entities.Department> queryable, int? parentId)
        {
            return queryable.Where(q => (q.ParentId == parentId || (parentId == null && q.ParentId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Department> ByRootId(this IQueryable<Sca.Data.Entities.Department> queryable, int? rootId)
        {
            return queryable.Where(q => (q.RootId == rootId || (rootId == null && q.RootId == null)));
        }

        #endregion

    }
}
