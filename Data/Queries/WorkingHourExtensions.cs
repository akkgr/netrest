using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class WorkingHourExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.WorkingHour GetByKey(this IQueryable<Sca.Data.Entities.WorkingHour> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.WorkingHour> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.WorkingHour> GetByKeyAsync(this IQueryable<Sca.Data.Entities.WorkingHour> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.WorkingHour> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.WorkingHour GetByOrgTreeNodeIdEmployeeIdYearMonthDay(this IQueryable<Sca.Data.Entities.WorkingHour> queryable, int orgTreeNodeId, int employeeId, int year, int month, int day)
        {
            return queryable.FirstOrDefault(q => q.OrgTreeNodeId == orgTreeNodeId
                && q.EmployeeId == employeeId
                    && q.Year == year
                        && q.Month == month
                            && q.Day == day);
                    }

                    public static Task<Sca.Data.Entities.WorkingHour> GetByOrgTreeNodeIdEmployeeIdYearMonthDayAsync(this IQueryable<Sca.Data.Entities.WorkingHour> queryable, int orgTreeNodeId, int employeeId, int year, int month, int day)
                    {
                        return queryable.FirstOrDefaultAsync(q => q.OrgTreeNodeId == orgTreeNodeId
                            && q.EmployeeId == employeeId
                                && q.Year == year
                                    && q.Month == month
                                        && q.Day == day);
                                }

                                public static IQueryable<Sca.Data.Entities.WorkingHour> ByEmployeeId(this IQueryable<Sca.Data.Entities.WorkingHour> queryable, int employeeId)
                                {
                                    return queryable.Where(q => q.EmployeeId == employeeId);
                                }

                                public static IQueryable<Sca.Data.Entities.WorkingHour> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.WorkingHour> queryable, int orgTreeNodeId)
                                {
                                    return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
                                }

                                #endregion

                            }
                        }
