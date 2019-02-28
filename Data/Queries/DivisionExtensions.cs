using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DivisionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Division GetByKey(this IQueryable<Sca.Data.Entities.Division> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Division> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Division> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Division> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Division> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
