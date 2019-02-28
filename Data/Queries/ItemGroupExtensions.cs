using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ItemGroupExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.ItemGroup GetByKey(this IQueryable<Sca.Data.Entities.ItemGroup> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ItemGroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.ItemGroup> GetByKeyAsync(this IQueryable<Sca.Data.Entities.ItemGroup> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ItemGroup> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.ItemGroup> ByItemId(this IQueryable<Sca.Data.Entities.ItemGroup> queryable, int itemId)
        {
            return queryable.Where(q => q.ItemId == itemId);
        }

        #endregion

    }
}
