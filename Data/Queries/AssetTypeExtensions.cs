using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AssetTypeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.AssetType GetByKey(this IQueryable<Sca.Data.Entities.AssetType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AssetType> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.AssetType> GetByKeyAsync(this IQueryable<Sca.Data.Entities.AssetType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AssetType> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
