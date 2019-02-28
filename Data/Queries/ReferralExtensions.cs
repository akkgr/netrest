using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ReferralExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Referral GetByKey(this IQueryable<Sca.Data.Entities.Referral> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Referral> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Referral> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Referral> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Referral> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Referral> ByClientId(this IQueryable<Sca.Data.Entities.Referral> queryable, int? clientId)
        {
            return queryable.Where(q => (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Referral> ByIntakeId(this IQueryable<Sca.Data.Entities.Referral> queryable, int? intakeId)
        {
            return queryable.Where(q => (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Referral> ByNewIntakeId(this IQueryable<Sca.Data.Entities.Referral> queryable, int? newIntakeId)
        {
            return queryable.Where(q => (q.NewIntakeId == newIntakeId || (newIntakeId == null && q.NewIntakeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Referral> ByFromOrgId(this IQueryable<Sca.Data.Entities.Referral> queryable, int fromOrgId)
        {
            return queryable.Where(q => q.FromOrgId == fromOrgId);
        }

        public static IQueryable<Sca.Data.Entities.Referral> ByToOrgId(this IQueryable<Sca.Data.Entities.Referral> queryable, int? toOrgId)
        {
            return queryable.Where(q => (q.ToOrgId == toOrgId || (toOrgId == null && q.ToOrgId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Referral> ByReferralLevelId(this IQueryable<Sca.Data.Entities.Referral> queryable, int? referralLevelId)
        {
            return queryable.Where(q => (q.ReferralLevelId == referralLevelId || (referralLevelId == null && q.ReferralLevelId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Referral> ByFromUserId(this IQueryable<Sca.Data.Entities.Referral> queryable, int fromUserId)
        {
            return queryable.Where(q => q.FromUserId == fromUserId);
        }

        public static IQueryable<Sca.Data.Entities.Referral> ByToUserId(this IQueryable<Sca.Data.Entities.Referral> queryable, int? toUserId)
        {
            return queryable.Where(q => (q.ToUserId == toUserId || (toUserId == null && q.ToUserId == null)));
        }

        #endregion

    }
}
