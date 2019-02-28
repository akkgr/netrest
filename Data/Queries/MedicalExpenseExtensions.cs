using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class MedicalExpenseExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.MedicalExpense GetByKey(this IQueryable<Sca.Data.Entities.MedicalExpense> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.MedicalExpense> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.MedicalExpense> GetByKeyAsync(this IQueryable<Sca.Data.Entities.MedicalExpense> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.MedicalExpense> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.MedicalExpense> ByInsurerId(this IQueryable<Sca.Data.Entities.MedicalExpense> queryable, int insurerId)
        {
            return queryable.Where(q => q.InsurerId == insurerId);
        }

        #endregion

    }
}
