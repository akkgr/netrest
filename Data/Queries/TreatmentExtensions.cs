using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class TreatmentExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Treatment GetByKey(this IQueryable<Sca.Data.Entities.Treatment> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Treatment> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Treatment> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Treatment> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Treatment> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Treatment> ByClientId(this IQueryable<Sca.Data.Entities.Treatment> queryable, int? clientId)
        {
            return queryable.Where(q => (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Treatment> ByIntakeId(this IQueryable<Sca.Data.Entities.Treatment> queryable, int? intakeId)
        {
            return queryable.Where(q => (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Treatment> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Treatment> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.Treatment> ByUserId(this IQueryable<Sca.Data.Entities.Treatment> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
