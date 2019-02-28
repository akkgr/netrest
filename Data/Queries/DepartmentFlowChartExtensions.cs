using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DepartmentFlowChartExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DepartmentFlowChart GetByKey(this IQueryable<Sca.Data.Entities.DepartmentFlowChart> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DepartmentFlowChart> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.DepartmentFlowChart> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DepartmentFlowChart> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DepartmentFlowChart> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.DepartmentFlowChart GetByDepartmentIdFlowChartId(this IQueryable<Sca.Data.Entities.DepartmentFlowChart> queryable, int departmentId, int flowChartId)
        {
            return queryable.FirstOrDefault(q => q.DepartmentId == departmentId
                && q.FlowChartId == flowChartId);
        }

        public static Task<Sca.Data.Entities.DepartmentFlowChart> GetByDepartmentIdFlowChartIdAsync(this IQueryable<Sca.Data.Entities.DepartmentFlowChart> queryable, int departmentId, int flowChartId)
        {
            return queryable.FirstOrDefaultAsync(q => q.DepartmentId == departmentId
                && q.FlowChartId == flowChartId);
        }

        public static IQueryable<Sca.Data.Entities.DepartmentFlowChart> ByDepartmentId(this IQueryable<Sca.Data.Entities.DepartmentFlowChart> queryable, int departmentId)
        {
            return queryable.Where(q => q.DepartmentId == departmentId);
        }

        public static IQueryable<Sca.Data.Entities.DepartmentFlowChart> ByFlowChartId(this IQueryable<Sca.Data.Entities.DepartmentFlowChart> queryable, int flowChartId)
        {
            return queryable.Where(q => q.FlowChartId == flowChartId);
        }

        #endregion

    }
}
