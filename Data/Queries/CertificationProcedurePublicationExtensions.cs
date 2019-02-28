using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CertificationProcedurePublicationExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.CertificationProcedurePublication GetByKey(this IQueryable<Sca.Data.Entities.CertificationProcedurePublication> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.CertificationProcedurePublication> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.CertificationProcedurePublication> GetByKeyAsync(this IQueryable<Sca.Data.Entities.CertificationProcedurePublication> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.CertificationProcedurePublication> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.CertificationProcedurePublication> ByProcedureId(this IQueryable<Sca.Data.Entities.CertificationProcedurePublication> queryable, int procedureId)
        {
            return queryable.Where(q => q.ProcedureId == procedureId);
        }

        public static IQueryable<Sca.Data.Entities.CertificationProcedurePublication> ByPublicationId(this IQueryable<Sca.Data.Entities.CertificationProcedurePublication> queryable, int publicationId)
        {
            return queryable.Where(q => q.PublicationId == publicationId);
        }

        #endregion

    }
}
