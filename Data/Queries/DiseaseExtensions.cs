using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DiseaseExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Disease GetByKey(this IQueryable<Sca.Data.Entities.Disease> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Disease> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Disease> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Disease> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Disease> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
