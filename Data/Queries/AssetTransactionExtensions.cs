using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AssetTransactionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.AssetTransaction GetByKey(this IQueryable<Sca.Data.Entities.AssetTransaction> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AssetTransaction> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.AssetTransaction> GetByKeyAsync(this IQueryable<Sca.Data.Entities.AssetTransaction> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AssetTransaction> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.AssetTransaction> ByAssetId(this IQueryable<Sca.Data.Entities.AssetTransaction> queryable, int assetId)
        {
            return queryable.Where(q => q.AssetId == assetId);
        }

        public static IQueryable<Sca.Data.Entities.AssetTransaction> ByEmployeeId(this IQueryable<Sca.Data.Entities.AssetTransaction> queryable, int? employeeId)
        {
            return queryable.Where(q => (q.EmployeeId == employeeId || (employeeId == null && q.EmployeeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.AssetTransaction> ByInvoiceTypeId(this IQueryable<Sca.Data.Entities.AssetTransaction> queryable, int? invoiceTypeId)
        {
            return queryable.Where(q => (q.InvoiceTypeId == invoiceTypeId || (invoiceTypeId == null && q.InvoiceTypeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.AssetTransaction> ByOrgFrom(this IQueryable<Sca.Data.Entities.AssetTransaction> queryable, int? orgFrom)
        {
            return queryable.Where(q => (q.OrgFrom == orgFrom || (orgFrom == null && q.OrgFrom == null)));
        }

        public static IQueryable<Sca.Data.Entities.AssetTransaction> ByOrgTo(this IQueryable<Sca.Data.Entities.AssetTransaction> queryable, int? orgTo)
        {
            return queryable.Where(q => (q.OrgTo == orgTo || (orgTo == null && q.OrgTo == null)));
        }

        public static IQueryable<Sca.Data.Entities.AssetTransaction> ByUserId(this IQueryable<Sca.Data.Entities.AssetTransaction> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
