using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class IntakePlanExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.IntakePlan GetByKey(this IQueryable<Sca.Data.Entities.IntakePlan> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.IntakePlan> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.IntakePlan> GetByKeyAsync(this IQueryable<Sca.Data.Entities.IntakePlan> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.IntakePlan> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.IntakePlan> ByEducationId(this IQueryable<Sca.Data.Entities.IntakePlan> queryable, int? educationId)
        {
            return queryable.Where(q => (q.EducationId == educationId || (educationId == null && q.EducationId == null)));
        }

        public static IQueryable<Sca.Data.Entities.IntakePlan> ByIntakeId(this IQueryable<Sca.Data.Entities.IntakePlan> queryable, int intakeId)
        {
            return queryable.Where(q => q.IntakeId == intakeId);
        }

        public static IQueryable<Sca.Data.Entities.IntakePlan> ByMaritalStatusId(this IQueryable<Sca.Data.Entities.IntakePlan> queryable, int? maritalStatusId)
        {
            return queryable.Where(q => (q.MaritalStatusId == maritalStatusId || (maritalStatusId == null && q.MaritalStatusId == null)));
        }

        public static IQueryable<Sca.Data.Entities.IntakePlan> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.IntakePlan> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.IntakePlan> ByUserId(this IQueryable<Sca.Data.Entities.IntakePlan> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
