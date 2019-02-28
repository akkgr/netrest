using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class FlowChartStepExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.FlowChartStep GetByKey(this IQueryable<Sca.Data.Entities.FlowChartStep> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.FlowChartStep> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.FlowChartStep> GetByKeyAsync(this IQueryable<Sca.Data.Entities.FlowChartStep> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.FlowChartStep> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.FlowChartStep> ByFlowChartId(this IQueryable<Sca.Data.Entities.FlowChartStep> queryable, int flowChartId)
        {
            return queryable.Where(q => q.FlowChartId == flowChartId);
        }

        #endregion

    }
}
