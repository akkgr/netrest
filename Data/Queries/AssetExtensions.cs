using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AssetExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Asset GetByKey(this IQueryable<Sca.Data.Entities.Asset> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Asset> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Asset> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Asset> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Asset> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Asset GetByBarcode(this IQueryable<Sca.Data.Entities.Asset> queryable, string barcode)
        {
            return queryable.FirstOrDefault(q => (q.Barcode == barcode || (barcode == null && q.Barcode == null)));
        }

        public static Task<Sca.Data.Entities.Asset> GetByBarcodeAsync(this IQueryable<Sca.Data.Entities.Asset> queryable, string barcode)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Barcode == barcode || (barcode == null && q.Barcode == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByAssetTypeId(this IQueryable<Sca.Data.Entities.Asset> queryable, int? assetTypeId)
        {
            return queryable.Where(q => (q.AssetTypeId == assetTypeId || (assetTypeId == null && q.AssetTypeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByClientId(this IQueryable<Sca.Data.Entities.Asset> queryable, int? clientId)
        {
            return queryable.Where(q => (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByRankId(this IQueryable<Sca.Data.Entities.Asset> queryable, int? rankId)
        {
            return queryable.Where(q => (q.RankId == rankId || (rankId == null && q.RankId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByEmployeeId(this IQueryable<Sca.Data.Entities.Asset> queryable, int? employeeId)
        {
            return queryable.Where(q => (q.EmployeeId == employeeId || (employeeId == null && q.EmployeeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByIntakeId(this IQueryable<Sca.Data.Entities.Asset> queryable, int? intakeId)
        {
            return queryable.Where(q => (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByInvoiceTypeId(this IQueryable<Sca.Data.Entities.Asset> queryable, int? invoiceTypeId)
        {
            return queryable.Where(q => (q.InvoiceTypeId == invoiceTypeId || (invoiceTypeId == null && q.InvoiceTypeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Asset> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByFirstOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Asset> queryable, int? firstOrgTreeNodeId)
        {
            return queryable.Where(q => (q.FirstOrgTreeNodeId == firstOrgTreeNodeId || (firstOrgTreeNodeId == null && q.FirstOrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Asset> ByUserId(this IQueryable<Sca.Data.Entities.Asset> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
