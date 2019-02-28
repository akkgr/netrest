using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class EmployeePaymentExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.EmployeePayment GetByKey(this IQueryable<Sca.Data.Entities.EmployeePayment> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.EmployeePayment> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.EmployeePayment> GetByKeyAsync(this IQueryable<Sca.Data.Entities.EmployeePayment> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.EmployeePayment> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.EmployeePayment> ByEmployeeId(this IQueryable<Sca.Data.Entities.EmployeePayment> queryable, int employeeId)
        {
            return queryable.Where(q => q.EmployeeId == employeeId);
        }

        public static IQueryable<Sca.Data.Entities.EmployeePayment> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.EmployeePayment> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.EmployeePayment> ByPaymentTypeId(this IQueryable<Sca.Data.Entities.EmployeePayment> queryable, int paymentTypeId)
        {
            return queryable.Where(q => q.PaymentTypeId == paymentTypeId);
        }

        #endregion

    }
}
