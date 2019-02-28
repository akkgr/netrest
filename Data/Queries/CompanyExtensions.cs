using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CompanyExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Company GetByKey(this IQueryable<Sca.Data.Entities.Company> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Company> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Company> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Company> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Company> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Company GetByAfm(this IQueryable<Sca.Data.Entities.Company> queryable, string afm)
        {
            return queryable.FirstOrDefault(q => (q.Afm == afm || (afm == null && q.Afm == null)));
        }

        public static Task<Sca.Data.Entities.Company> GetByAfmAsync(this IQueryable<Sca.Data.Entities.Company> queryable, string afm)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Afm == afm || (afm == null && q.Afm == null)));
        }

        public static IQueryable<Sca.Data.Entities.Company> ByTitle(this IQueryable<Sca.Data.Entities.Company> queryable, string title)
        {
            return queryable.Where(q => (q.Title == title || (title == null && q.Title == null)));
        }

        public static IQueryable<Sca.Data.Entities.Company> ByDoyId(this IQueryable<Sca.Data.Entities.Company> queryable, int? doyId)
        {
            return queryable.Where(q => (q.DoyId == doyId || (doyId == null && q.DoyId == null)));
        }

        #endregion

    }
}
