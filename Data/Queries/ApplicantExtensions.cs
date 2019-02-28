using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ApplicantExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Applicant GetByKey(this IQueryable<Sca.Data.Entities.Applicant> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Applicant> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Applicant> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Applicant> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Applicant> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Applicant> ByDegreeId(this IQueryable<Sca.Data.Entities.Applicant> queryable, int? degreeId)
        {
            return queryable.Where(q => (q.DegreeId == degreeId || (degreeId == null && q.DegreeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Applicant> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Applicant> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Applicant> BySpecialtyId(this IQueryable<Sca.Data.Entities.Applicant> queryable, int? specialtyId)
        {
            return queryable.Where(q => (q.SpecialtyId == specialtyId || (specialtyId == null && q.SpecialtyId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Applicant> ByUserId(this IQueryable<Sca.Data.Entities.Applicant> queryable, int? userId)
        {
            return queryable.Where(q => (q.UserId == userId || (userId == null && q.UserId == null)));
        }

        #endregion

    }
}
