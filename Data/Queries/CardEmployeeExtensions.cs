using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CardEmployeeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.CardEmployee GetByKey(this IQueryable<Sca.Data.Entities.CardEmployee> queryable, int cardId, int employeeId)
        {
            if (queryable is DbSet<Sca.Data.Entities.CardEmployee> dbSet)
                return dbSet.Find(cardId, employeeId);

            return queryable.FirstOrDefault(q => q.CardId == cardId
                && q.EmployeeId == employeeId);
        }

        public static Task<Sca.Data.Entities.CardEmployee> GetByKeyAsync(this IQueryable<Sca.Data.Entities.CardEmployee> queryable, int cardId, int employeeId)
        {
            if (queryable is DbSet<Sca.Data.Entities.CardEmployee> dbSet)
                return dbSet.FindAsync(cardId, employeeId);

            return queryable.FirstOrDefaultAsync(q => q.CardId == cardId
                && q.EmployeeId == employeeId);
        }

        public static IQueryable<Sca.Data.Entities.CardEmployee> ByCardId(this IQueryable<Sca.Data.Entities.CardEmployee> queryable, int cardId)
        {
            return queryable.Where(q => q.CardId == cardId);
        }

        public static IQueryable<Sca.Data.Entities.CardEmployee> ByEmployeeId(this IQueryable<Sca.Data.Entities.CardEmployee> queryable, int employeeId)
        {
            return queryable.Where(q => q.EmployeeId == employeeId);
        }

        #endregion

    }
}
