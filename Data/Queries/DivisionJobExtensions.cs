using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DivisionJobExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DivisionJob GetByKey(this IQueryable<Sca.Data.Entities.DivisionJob> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DivisionJob> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.DivisionJob> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DivisionJob> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DivisionJob> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.DivisionJob> ByDivisionId(this IQueryable<Sca.Data.Entities.DivisionJob> queryable, int divisionId)
        {
            return queryable.Where(q => q.DivisionId == divisionId);
        }

        #endregion

    }
}
