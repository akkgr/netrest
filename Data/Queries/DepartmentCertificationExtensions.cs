using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DepartmentCertificationExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DepartmentCertification GetByKey(this IQueryable<Sca.Data.Entities.DepartmentCertification> queryable, int departmentId, int certificationId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DepartmentCertification> dbSet)
                return dbSet.Find(departmentId, certificationId);

            return queryable.FirstOrDefault(q => q.DepartmentId == departmentId
                && q.CertificationId == certificationId);
        }

        public static Task<Sca.Data.Entities.DepartmentCertification> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DepartmentCertification> queryable, int departmentId, int certificationId)
        {
            if (queryable is DbSet<Sca.Data.Entities.DepartmentCertification> dbSet)
                return dbSet.FindAsync(departmentId, certificationId);

            return queryable.FirstOrDefaultAsync(q => q.DepartmentId == departmentId
                && q.CertificationId == certificationId);
        }

        public static IQueryable<Sca.Data.Entities.DepartmentCertification> ByCertificationId(this IQueryable<Sca.Data.Entities.DepartmentCertification> queryable, int certificationId)
        {
            return queryable.Where(q => q.CertificationId == certificationId);
        }

        public static IQueryable<Sca.Data.Entities.DepartmentCertification> ByDepartmentId(this IQueryable<Sca.Data.Entities.DepartmentCertification> queryable, int departmentId)
        {
            return queryable.Where(q => q.DepartmentId == departmentId);
        }

        #endregion

    }
}
