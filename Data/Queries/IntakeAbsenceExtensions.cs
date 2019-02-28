using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class IntakeAbsenceExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.IntakeAbsence GetByKey(this IQueryable<Sca.Data.Entities.IntakeAbsence> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.IntakeAbsence> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.IntakeAbsence> GetByKeyAsync(this IQueryable<Sca.Data.Entities.IntakeAbsence> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.IntakeAbsence> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.IntakeAbsence> ByIntakeId(this IQueryable<Sca.Data.Entities.IntakeAbsence> queryable, int intakeId)
        {
            return queryable.Where(q => q.IntakeId == intakeId);
        }

        public static IQueryable<Sca.Data.Entities.IntakeAbsence> ByTypeId(this IQueryable<Sca.Data.Entities.IntakeAbsence> queryable, int typeId)
        {
            return queryable.Where(q => q.TypeId == typeId);
        }

        #endregion

    }
}
