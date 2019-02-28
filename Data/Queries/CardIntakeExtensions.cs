using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CardIntakeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.CardIntake GetByKey(this IQueryable<Sca.Data.Entities.CardIntake> queryable, int cardId, int intakeId)
        {
            if (queryable is DbSet<Sca.Data.Entities.CardIntake> dbSet)
                return dbSet.Find(cardId, intakeId);

            return queryable.FirstOrDefault(q => q.CardId == cardId
                && q.IntakeId == intakeId);
        }

        public static Task<Sca.Data.Entities.CardIntake> GetByKeyAsync(this IQueryable<Sca.Data.Entities.CardIntake> queryable, int cardId, int intakeId)
        {
            if (queryable is DbSet<Sca.Data.Entities.CardIntake> dbSet)
                return dbSet.FindAsync(cardId, intakeId);

            return queryable.FirstOrDefaultAsync(q => q.CardId == cardId
                && q.IntakeId == intakeId);
        }

        public static IQueryable<Sca.Data.Entities.CardIntake> ByCardId(this IQueryable<Sca.Data.Entities.CardIntake> queryable, int cardId)
        {
            return queryable.Where(q => q.CardId == cardId);
        }

        public static IQueryable<Sca.Data.Entities.CardIntake> ByIntakeId(this IQueryable<Sca.Data.Entities.CardIntake> queryable, int intakeId)
        {
            return queryable.Where(q => q.IntakeId == intakeId);
        }

        #endregion

    }
}
