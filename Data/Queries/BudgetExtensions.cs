using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class BudgetExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Budget GetByKey(this IQueryable<Sca.Data.Entities.Budget> queryable, int orgTreeNodeId, int financeYear, int activityCodeId)
        {
            if (queryable is DbSet<Sca.Data.Entities.Budget> dbSet)
                return dbSet.Find(orgTreeNodeId, financeYear, activityCodeId);

            return queryable.FirstOrDefault(q => q.OrgTreeNodeId == orgTreeNodeId
                && q.FinanceYear == financeYear
                    && q.ActivityCodeId == activityCodeId);
            }

            public static Task<Sca.Data.Entities.Budget> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Budget> queryable, int orgTreeNodeId, int financeYear, int activityCodeId)
            {
                if (queryable is DbSet<Sca.Data.Entities.Budget> dbSet)
                    return dbSet.FindAsync(orgTreeNodeId, financeYear, activityCodeId);

                return queryable.FirstOrDefaultAsync(q => q.OrgTreeNodeId == orgTreeNodeId
                    && q.FinanceYear == financeYear
                        && q.ActivityCodeId == activityCodeId);
                }

                public static IQueryable<Sca.Data.Entities.Budget> ByActivityCodeId(this IQueryable<Sca.Data.Entities.Budget> queryable, int activityCodeId)
                {
                    return queryable.Where(q => q.ActivityCodeId == activityCodeId);
                }

                public static IQueryable<Sca.Data.Entities.Budget> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Budget> queryable, int orgTreeNodeId)
                {
                    return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
                }

                #endregion

            }
        }
