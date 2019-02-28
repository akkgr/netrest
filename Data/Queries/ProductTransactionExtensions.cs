using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ProductTransactionExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.ProductTransaction GetByKey(this IQueryable<Sca.Data.Entities.ProductTransaction> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ProductTransaction> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.ProductTransaction> GetByKeyAsync(this IQueryable<Sca.Data.Entities.ProductTransaction> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ProductTransaction> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.ProductTransaction> ByFoodMenuIdIntakeIdInternalUseItemIdOrgTreeNodeIdProductProductDateQuantityRemarksRowVersionTransactionCauseTransactionDateTransferDestroyUserIdClientId(this IQueryable<Sca.Data.Entities.ProductTransaction> queryable, int? foodMenuId, int? intakeId, bool internalUse, decimal? itemId, int? orgTreeNodeId, string product, DateTime productDate, decimal? quantity, string remarks, Byte[] rowVersion, string transactionCause, DateTime transactionDate, bool transferDestroy, int userId, int? clientId)
        {
            return queryable.Where(q => (q.FoodMenuId == foodMenuId || (foodMenuId == null && q.FoodMenuId == null))
                && (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null))
                    && q.InternalUse == internalUse
                        && (q.ItemId == itemId || (itemId == null && q.ItemId == null))
                            && (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null))
                                && q.Product == product
                                    && q.ProductDate == productDate
                                        && (q.Quantity == quantity || (quantity == null && q.Quantity == null))
                                            && (q.Remarks == remarks || (remarks == null && q.Remarks == null))
                                                && (q.RowVersion == rowVersion || (rowVersion == null && q.RowVersion == null))
                                                    && (q.TransactionCause == transactionCause || (transactionCause == null && q.TransactionCause == null))
                                                        && q.TransactionDate == transactionDate
                                                            && q.TransferDestroy == transferDestroy
                                                                && q.UserId == userId
                                                                    && (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
                                                            }

                                                            public static IQueryable<Sca.Data.Entities.ProductTransaction> ByClientId(this IQueryable<Sca.Data.Entities.ProductTransaction> queryable, int? clientId)
                                                            {
                                                                return queryable.Where(q => (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
                                                            }

                                                            public static IQueryable<Sca.Data.Entities.ProductTransaction> ByFoodMenuId(this IQueryable<Sca.Data.Entities.ProductTransaction> queryable, int? foodMenuId)
                                                            {
                                                                return queryable.Where(q => (q.FoodMenuId == foodMenuId || (foodMenuId == null && q.FoodMenuId == null)));
                                                            }

                                                            public static IQueryable<Sca.Data.Entities.ProductTransaction> ByIntakeId(this IQueryable<Sca.Data.Entities.ProductTransaction> queryable, int? intakeId)
                                                            {
                                                                return queryable.Where(q => (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null)));
                                                            }

                                                            public static IQueryable<Sca.Data.Entities.ProductTransaction> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.ProductTransaction> queryable, int? orgTreeNodeId)
                                                            {
                                                                return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
                                                            }

                                                            public static IQueryable<Sca.Data.Entities.ProductTransaction> ByUserId(this IQueryable<Sca.Data.Entities.ProductTransaction> queryable, int userId)
                                                            {
                                                                return queryable.Where(q => q.UserId == userId);
                                                            }

                                                            #endregion

                                                        }
                                                    }
