using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ItemTransactionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.ItemTransaction GetByKey(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ItemTransaction> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.ItemTransaction> GetByKeyAsync(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ItemTransaction> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.ItemTransaction> ByBarCodeCategoryIdClientIdDoctorInternalUseInvoiceItemIdOrgTreeNodeIdOriginIdPackagingIdPrescriptionPriceProcessedQuantityRemarksRowVersionRunningTotalTitleTransactionCauseTransactionDateTransactionTypeTransferDestroyUnitIdUserIdXpirationIntakeId(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, string barCode, int categoryId, int? clientId, string doctor, bool internalUse, string invoice, int itemId, int? orgTreeNodeId, int? originId, int packagingId, string prescription, decimal price, bool processed, decimal quantity, string remarks, Byte[] rowVersion, decimal? runningTotal, string title, string transactionCause, DateTime transactionDate, decimal transactionType, bool transferDestroy, int unitId, int userId, DateTime? xpiration, int? intakeId)
        {
            return queryable.Where(q => q.BarCode == barCode
                && q.CategoryId == categoryId
                    && (q.ClientId == clientId || (clientId == null && q.ClientId == null))
                        && (q.Doctor == doctor || (doctor == null && q.Doctor == null))
                            && q.InternalUse == internalUse
                                && (q.Invoice == invoice || (invoice == null && q.Invoice == null))
                                    && q.ItemId == itemId
                                        && (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null))
                                            && (q.OriginId == originId || (originId == null && q.OriginId == null))
                                                && q.PackagingId == packagingId
                                                    && (q.Prescription == prescription || (prescription == null && q.Prescription == null))
                                                        && q.Price == price
                                                            && q.Processed == processed
                                                                && q.Quantity == quantity
                                                                    && (q.Remarks == remarks || (remarks == null && q.Remarks == null))
                                                                        && (q.RowVersion == rowVersion || (rowVersion == null && q.RowVersion == null))
                                                                            && (q.RunningTotal == runningTotal || (runningTotal == null && q.RunningTotal == null))
                                                                                && q.Title == title
                                                                                    && (q.TransactionCause == transactionCause || (transactionCause == null && q.TransactionCause == null))
                                                                                        && q.TransactionDate == transactionDate
                                                                                            && q.TransactionType == transactionType
                                                                                                && q.TransferDestroy == transferDestroy
                                                                                                    && q.UnitId == unitId
                                                                                                        && q.UserId == userId
                                                                                                            && (q.Xpiration == xpiration || (xpiration == null && q.Xpiration == null))
                                                                                                                && (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null)));
                                                                                                        }

                                                                                                        public static IQueryable<Sca.Data.Entities.ItemTransaction> ByBarCodeCategoryIdDoctorIntakeIdInternalUseInvoiceItemIdOrgTreeNodeIdOriginIdPackagingIdPrescriptionPriceProcessedQuantityRemarksRowVersionRunningTotalTitleTransactionCauseTransactionDateTransactionTypeTransferDestroyUnitIdUserIdXpirationClientId(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, string barCode, int categoryId, string doctor, int? intakeId, bool internalUse, string invoice, int itemId, int? orgTreeNodeId, int? originId, int packagingId, string prescription, decimal price, bool processed, decimal quantity, string remarks, Byte[] rowVersion, decimal? runningTotal, string title, string transactionCause, DateTime transactionDate, decimal transactionType, bool transferDestroy, int unitId, int userId, DateTime? xpiration, int? clientId)
                                                                                                        {
                                                                                                            return queryable.Where(q => q.BarCode == barCode
                                                                                                                && q.CategoryId == categoryId
                                                                                                                    && (q.Doctor == doctor || (doctor == null && q.Doctor == null))
                                                                                                                        && (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null))
                                                                                                                            && q.InternalUse == internalUse
                                                                                                                                && (q.Invoice == invoice || (invoice == null && q.Invoice == null))
                                                                                                                                    && q.ItemId == itemId
                                                                                                                                        && (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null))
                                                                                                                                            && (q.OriginId == originId || (originId == null && q.OriginId == null))
                                                                                                                                                && q.PackagingId == packagingId
                                                                                                                                                    && (q.Prescription == prescription || (prescription == null && q.Prescription == null))
                                                                                                                                                        && q.Price == price
                                                                                                                                                            && q.Processed == processed
                                                                                                                                                                && q.Quantity == quantity
                                                                                                                                                                    && (q.Remarks == remarks || (remarks == null && q.Remarks == null))
                                                                                                                                                                        && (q.RowVersion == rowVersion || (rowVersion == null && q.RowVersion == null))
                                                                                                                                                                            && (q.RunningTotal == runningTotal || (runningTotal == null && q.RunningTotal == null))
                                                                                                                                                                                && q.Title == title
                                                                                                                                                                                    && (q.TransactionCause == transactionCause || (transactionCause == null && q.TransactionCause == null))
                                                                                                                                                                                        && q.TransactionDate == transactionDate
                                                                                                                                                                                            && q.TransactionType == transactionType
                                                                                                                                                                                                && q.TransferDestroy == transferDestroy
                                                                                                                                                                                                    && q.UnitId == unitId
                                                                                                                                                                                                        && q.UserId == userId
                                                                                                                                                                                                            && (q.Xpiration == xpiration || (xpiration == null && q.Xpiration == null))
                                                                                                                                                                                                                && (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
                                                                                                                                                                                                        }

                                                                                                                                                                                                        public static IQueryable<Sca.Data.Entities.ItemTransaction> ByClientId(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, int? clientId)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            return queryable.Where(q => (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
                                                                                                                                                                                                        }

                                                                                                                                                                                                        public static IQueryable<Sca.Data.Entities.ItemTransaction> ByIntakeId(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, int? intakeId)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            return queryable.Where(q => (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null)));
                                                                                                                                                                                                        }

                                                                                                                                                                                                        public static IQueryable<Sca.Data.Entities.ItemTransaction> ByItemId(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, int itemId)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            return queryable.Where(q => q.ItemId == itemId);
                                                                                                                                                                                                        }

                                                                                                                                                                                                        public static IQueryable<Sca.Data.Entities.ItemTransaction> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, int? orgTreeNodeId)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
                                                                                                                                                                                                        }

                                                                                                                                                                                                        public static IQueryable<Sca.Data.Entities.ItemTransaction> ByOriginId(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, int? originId)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            return queryable.Where(q => (q.OriginId == originId || (originId == null && q.OriginId == null)));
                                                                                                                                                                                                        }

                                                                                                                                                                                                        public static IQueryable<Sca.Data.Entities.ItemTransaction> ByUserId(this IQueryable<Sca.Data.Entities.ItemTransaction> queryable, int userId)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            return queryable.Where(q => q.UserId == userId);
                                                                                                                                                                                                        }

                                                                                                                                                                                                        #endregion

                                                                                                                                                                                                    }
                                                                                                                                                                                                }
