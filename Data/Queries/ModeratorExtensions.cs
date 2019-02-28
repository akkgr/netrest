using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ModeratorExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Moderator GetByKey(this IQueryable<Sca.Data.Entities.Moderator> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Moderator> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Moderator> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Moderator> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Moderator> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Moderator> ByEmployeeIdFullNameIsEmployeeIsUserRowVersionUserIdWorkGroupIdAppointmentId(this IQueryable<Sca.Data.Entities.Moderator> queryable, int? employeeId, string fullName, bool isEmployee, bool isUser, Byte[] rowVersion, int? userId, int? workGroupId, int? appointmentId)
        {
            return queryable.Where(q => (q.EmployeeId == employeeId || (employeeId == null && q.EmployeeId == null))
                && (q.FullName == fullName || (fullName == null && q.FullName == null))
                    && q.IsEmployee == isEmployee
                        && q.IsUser == isUser
                            && (q.RowVersion == rowVersion || (rowVersion == null && q.RowVersion == null))
                                && (q.UserId == userId || (userId == null && q.UserId == null))
                                    && (q.WorkGroupId == workGroupId || (workGroupId == null && q.WorkGroupId == null))
                                        && (q.AppointmentId == appointmentId || (appointmentId == null && q.AppointmentId == null)));
                                }

                                public static IQueryable<Sca.Data.Entities.Moderator> ByAppointmentId(this IQueryable<Sca.Data.Entities.Moderator> queryable, int? appointmentId)
                                {
                                    return queryable.Where(q => (q.AppointmentId == appointmentId || (appointmentId == null && q.AppointmentId == null)));
                                }

                                public static IQueryable<Sca.Data.Entities.Moderator> ByEmployeeId(this IQueryable<Sca.Data.Entities.Moderator> queryable, int? employeeId)
                                {
                                    return queryable.Where(q => (q.EmployeeId == employeeId || (employeeId == null && q.EmployeeId == null)));
                                }

                                public static IQueryable<Sca.Data.Entities.Moderator> ByUserId(this IQueryable<Sca.Data.Entities.Moderator> queryable, int? userId)
                                {
                                    return queryable.Where(q => (q.UserId == userId || (userId == null && q.UserId == null)));
                                }

                                public static IQueryable<Sca.Data.Entities.Moderator> ByWorkGroupId(this IQueryable<Sca.Data.Entities.Moderator> queryable, int? workGroupId)
                                {
                                    return queryable.Where(q => (q.WorkGroupId == workGroupId || (workGroupId == null && q.WorkGroupId == null)));
                                }

                                #endregion

                            }
                        }
