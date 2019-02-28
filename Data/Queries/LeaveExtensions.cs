using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class LeaveExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Leave GetByKey(this IQueryable<Sca.Data.Entities.Leave> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Leave> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Leave> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Leave> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Leave> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Leave GetByEmployeeIdOrgTreeNodeIdBsenceTypeIdYear(this IQueryable<Sca.Data.Entities.Leave> queryable, int employeeId, int orgTreeNodeId, int bsenceTypeId, int year)
        {
            return queryable.FirstOrDefault(q => q.EmployeeId == employeeId
                && q.OrgTreeNodeId == orgTreeNodeId
                    && q.BsenceTypeId == bsenceTypeId
                        && q.Year == year);
                }

                public static Task<Sca.Data.Entities.Leave> GetByEmployeeIdOrgTreeNodeIdBsenceTypeIdYearAsync(this IQueryable<Sca.Data.Entities.Leave> queryable, int employeeId, int orgTreeNodeId, int bsenceTypeId, int year)
                {
                    return queryable.FirstOrDefaultAsync(q => q.EmployeeId == employeeId
                        && q.OrgTreeNodeId == orgTreeNodeId
                            && q.BsenceTypeId == bsenceTypeId
                                && q.Year == year);
                        }

                        public static IQueryable<Sca.Data.Entities.Leave> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Leave> queryable, int orgTreeNodeId)
                        {
                            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
                        }

                        public static IQueryable<Sca.Data.Entities.Leave> ByBsenceTypeId(this IQueryable<Sca.Data.Entities.Leave> queryable, int bsenceTypeId)
                        {
                            return queryable.Where(q => q.BsenceTypeId == bsenceTypeId);
                        }

                        public static IQueryable<Sca.Data.Entities.Leave> ByEmployeeId(this IQueryable<Sca.Data.Entities.Leave> queryable, int employeeId)
                        {
                            return queryable.Where(q => q.EmployeeId == employeeId);
                        }

                        #endregion

                    }
                }
