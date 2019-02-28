using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CardClientExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.CardClient GetByKey(this IQueryable<Sca.Data.Entities.CardClient> queryable, int cardId, int clientId)
        {
            if (queryable is DbSet<Sca.Data.Entities.CardClient> dbSet)
                return dbSet.Find(cardId, clientId);

            return queryable.FirstOrDefault(q => q.CardId == cardId
                && q.ClientId == clientId);
        }

        public static Task<Sca.Data.Entities.CardClient> GetByKeyAsync(this IQueryable<Sca.Data.Entities.CardClient> queryable, int cardId, int clientId)
        {
            if (queryable is DbSet<Sca.Data.Entities.CardClient> dbSet)
                return dbSet.FindAsync(cardId, clientId);

            return queryable.FirstOrDefaultAsync(q => q.CardId == cardId
                && q.ClientId == clientId);
        }

        public static IQueryable<Sca.Data.Entities.CardClient> ByCardId(this IQueryable<Sca.Data.Entities.CardClient> queryable, int cardId)
        {
            return queryable.Where(q => q.CardId == cardId);
        }

        public static IQueryable<Sca.Data.Entities.CardClient> ByClientId(this IQueryable<Sca.Data.Entities.CardClient> queryable, int clientId)
        {
            return queryable.Where(q => q.ClientId == clientId);
        }

        #endregion

    }
}
