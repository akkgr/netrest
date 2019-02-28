using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class InvoiceExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Invoice GetByKey(this IQueryable<Sca.Data.Entities.Invoice> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Invoice> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Invoice> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Invoice> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Invoice> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Invoice> ByRegistered(this IQueryable<Sca.Data.Entities.Invoice> queryable, DateTime registered)
        {
            return queryable.Where(q => q.Registered == registered);
        }

        public static Sca.Data.Entities.Invoice GetByCompanyAFMInvoiceTypeIdInvoiceNumber(this IQueryable<Sca.Data.Entities.Invoice> queryable, string companyAFM, int invoiceTypeId, string invoiceNumber)
        {
            return queryable.FirstOrDefault(q => q.CompanyAFM == companyAFM
                && q.InvoiceTypeId == invoiceTypeId
                    && q.InvoiceNumber == invoiceNumber);
            }

            public static Task<Sca.Data.Entities.Invoice> GetByCompanyAFMInvoiceTypeIdInvoiceNumberAsync(this IQueryable<Sca.Data.Entities.Invoice> queryable, string companyAFM, int invoiceTypeId, string invoiceNumber)
            {
                return queryable.FirstOrDefaultAsync(q => q.CompanyAFM == companyAFM
                    && q.InvoiceTypeId == invoiceTypeId
                        && q.InvoiceNumber == invoiceNumber);
                }

                public static IQueryable<Sca.Data.Entities.Invoice> ByCashActionOrgTreeNodeIdRetentionSumTotalAmountTransferAmountVirtualNodeIdIsCashNotInReportRegistered(this IQueryable<Sca.Data.Entities.Invoice> queryable, int cashAction, int orgTreeNodeId, decimal retentionSum, decimal totalAmount, decimal transferAmount, int? virtualNodeId, bool isCash, bool notInReport, DateTime registered)
                {
                    return queryable.Where(q => q.CashAction == cashAction
                        && q.OrgTreeNodeId == orgTreeNodeId
                            && q.RetentionSum == retentionSum
                                && q.TotalAmount == totalAmount
                                    && q.TransferAmount == transferAmount
                                        && (q.VirtualNodeId == virtualNodeId || (virtualNodeId == null && q.VirtualNodeId == null))
                                            && q.IsCash == isCash
                                                && q.NotInReport == notInReport
                                                    && q.Registered == registered);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByActivityCodeId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int activityCodeId)
                                            {
                                                return queryable.Where(q => q.ActivityCodeId == activityCodeId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByCompanyId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int companyId)
                                            {
                                                return queryable.Where(q => q.CompanyId == companyId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByDocRankId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int docRankId)
                                            {
                                                return queryable.Where(q => q.DocRankId == docRankId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByInvoiceId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int? invoiceId)
                                            {
                                                return queryable.Where(q => (q.InvoiceId == invoiceId || (invoiceId == null && q.InvoiceId == null)));
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByInvoiceTypeId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int invoiceTypeId)
                                            {
                                                return queryable.Where(q => q.InvoiceTypeId == invoiceTypeId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int orgTreeNodeId)
                                            {
                                                return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByCompanyNodeId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int companyNodeId)
                                            {
                                                return queryable.Where(q => q.CompanyNodeId == companyNodeId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByVirtualNodeId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int? virtualNodeId)
                                            {
                                                return queryable.Where(q => (q.VirtualNodeId == virtualNodeId || (virtualNodeId == null && q.VirtualNodeId == null)));
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByTransactionTypeId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int transactionTypeId)
                                            {
                                                return queryable.Where(q => q.TransactionTypeId == transactionTypeId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Invoice> ByUserId(this IQueryable<Sca.Data.Entities.Invoice> queryable, int userId)
                                            {
                                                return queryable.Where(q => q.UserId == userId);
                                            }

                                            #endregion

                                        }
                                    }
