using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class IntakeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Intake GetByKey(this IQueryable<Sca.Data.Entities.Intake> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Intake> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Intake> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Intake> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Intake> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Intake> ByDocRankId(this IQueryable<Sca.Data.Entities.Intake> queryable, int docRankId)
        {
            return queryable.Where(q => q.DocRankId == docRankId);
        }

        public static IQueryable<Sca.Data.Entities.Intake> ByEducationId(this IQueryable<Sca.Data.Entities.Intake> queryable, int? educationId)
        {
            return queryable.Where(q => (q.EducationId == educationId || (educationId == null && q.EducationId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Intake> ByMaritalStatusId(this IQueryable<Sca.Data.Entities.Intake> queryable, int? maritalStatusId)
        {
            return queryable.Where(q => (q.MaritalStatusId == maritalStatusId || (maritalStatusId == null && q.MaritalStatusId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Intake> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Intake> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.Intake> ByUserId(this IQueryable<Sca.Data.Entities.Intake> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
