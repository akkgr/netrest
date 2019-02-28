using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class WorkGroupTypeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.WorkGroupType GetByKey(this IQueryable<Sca.Data.Entities.WorkGroupType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.WorkGroupType> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.WorkGroupType> GetByKeyAsync(this IQueryable<Sca.Data.Entities.WorkGroupType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.WorkGroupType> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
