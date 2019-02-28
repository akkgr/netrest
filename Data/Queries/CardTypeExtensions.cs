using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CardTypeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.CardType GetByKey(this IQueryable<Sca.Data.Entities.CardType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.CardType> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.CardType> GetByKeyAsync(this IQueryable<Sca.Data.Entities.CardType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.CardType> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.CardType GetByTitle(this IQueryable<Sca.Data.Entities.CardType> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.CardType> GetByTitleAsync(this IQueryable<Sca.Data.Entities.CardType> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
