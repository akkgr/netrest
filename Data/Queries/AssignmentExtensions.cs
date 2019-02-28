using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AssignmentExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Assignment GetByKey(this IQueryable<Sca.Data.Entities.Assignment> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Assignment> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Assignment> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Assignment> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Assignment> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Assignment> ByClientId(this IQueryable<Sca.Data.Entities.Assignment> queryable, int? clientId)
        {
            return queryable.Where(q => (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Assignment> ByIntakeId(this IQueryable<Sca.Data.Entities.Assignment> queryable, int? intakeId)
        {
            return queryable.Where(q => (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Assignment> ByOwnerId(this IQueryable<Sca.Data.Entities.Assignment> queryable, int ownerId)
        {
            return queryable.Where(q => q.OwnerId == ownerId);
        }

        public static IQueryable<Sca.Data.Entities.Assignment> ByResponsibleId(this IQueryable<Sca.Data.Entities.Assignment> queryable, int responsibleId)
        {
            return queryable.Where(q => q.ResponsibleId == responsibleId);
        }

        #endregion

    }
}
