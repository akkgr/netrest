using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CertificationProcedureExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.CertificationProcedure GetByKey(this IQueryable<Sca.Data.Entities.CertificationProcedure> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.CertificationProcedure> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.CertificationProcedure> GetByKeyAsync(this IQueryable<Sca.Data.Entities.CertificationProcedure> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.CertificationProcedure> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.CertificationProcedure> ByCertificationId(this IQueryable<Sca.Data.Entities.CertificationProcedure> queryable, int certificationId)
        {
            return queryable.Where(q => q.CertificationId == certificationId);
        }

        #endregion

    }
}
