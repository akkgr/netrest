using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class IntakeBenefitExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.IntakeBenefit GetByKey(this IQueryable<Sca.Data.Entities.IntakeBenefit> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.IntakeBenefit> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.IntakeBenefit> GetByKeyAsync(this IQueryable<Sca.Data.Entities.IntakeBenefit> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.IntakeBenefit> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
