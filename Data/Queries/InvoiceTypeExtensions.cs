using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class InvoiceTypeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.InvoiceType GetByKey(this IQueryable<Sca.Data.Entities.InvoiceType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.InvoiceType> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.InvoiceType> GetByKeyAsync(this IQueryable<Sca.Data.Entities.InvoiceType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.InvoiceType> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        #endregion

    }
}
