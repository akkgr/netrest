using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class PublicationDivisionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.PublicationDivision GetByKey(this IQueryable<Sca.Data.Entities.PublicationDivision> queryable, int publicationId, int divisionId)
        {
            if (queryable is DbSet<Sca.Data.Entities.PublicationDivision> dbSet)
                return dbSet.Find(publicationId, divisionId);

            return queryable.FirstOrDefault(q => q.PublicationId == publicationId
                && q.DivisionId == divisionId);
        }

        public static Task<Sca.Data.Entities.PublicationDivision> GetByKeyAsync(this IQueryable<Sca.Data.Entities.PublicationDivision> queryable, int publicationId, int divisionId)
        {
            if (queryable is DbSet<Sca.Data.Entities.PublicationDivision> dbSet)
                return dbSet.FindAsync(publicationId, divisionId);

            return queryable.FirstOrDefaultAsync(q => q.PublicationId == publicationId
                && q.DivisionId == divisionId);
        }

        public static IQueryable<Sca.Data.Entities.PublicationDivision> ByDivisionId(this IQueryable<Sca.Data.Entities.PublicationDivision> queryable, int divisionId)
        {
            return queryable.Where(q => q.DivisionId == divisionId);
        }

        public static IQueryable<Sca.Data.Entities.PublicationDivision> ByPublicationId(this IQueryable<Sca.Data.Entities.PublicationDivision> queryable, int publicationId)
        {
            return queryable.Where(q => q.PublicationId == publicationId);
        }

        #endregion

    }
}
