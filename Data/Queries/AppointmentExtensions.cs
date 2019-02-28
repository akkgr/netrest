using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AppointmentExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Appointment GetByKey(this IQueryable<Sca.Data.Entities.Appointment> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Appointment> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Appointment> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Appointment> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Appointment> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Appointment> ByAppointmentTypeId(this IQueryable<Sca.Data.Entities.Appointment> queryable, int? appointmentTypeId)
        {
            return queryable.Where(q => (q.AppointmentTypeId == appointmentTypeId || (appointmentTypeId == null && q.AppointmentTypeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Appointment> ByRankId(this IQueryable<Sca.Data.Entities.Appointment> queryable, int? rankId)
        {
            return queryable.Where(q => (q.RankId == rankId || (rankId == null && q.RankId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Appointment> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Appointment> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Appointment> ByUserId(this IQueryable<Sca.Data.Entities.Appointment> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static IQueryable<Sca.Data.Entities.Appointment> ByWorkGroupId(this IQueryable<Sca.Data.Entities.Appointment> queryable, int? workGroupId)
        {
            return queryable.Where(q => (q.WorkGroupId == workGroupId || (workGroupId == null && q.WorkGroupId == null)));
        }

        #endregion

    }
}
