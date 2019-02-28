using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AppointmentSpecialtyExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.AppointmentSpecialty GetByKey(this IQueryable<Sca.Data.Entities.AppointmentSpecialty> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AppointmentSpecialty> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.AppointmentSpecialty> GetByKeyAsync(this IQueryable<Sca.Data.Entities.AppointmentSpecialty> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AppointmentSpecialty> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.AppointmentSpecialty> ByAppointmentId(this IQueryable<Sca.Data.Entities.AppointmentSpecialty> queryable, int appointmentId)
        {
            return queryable.Where(q => q.AppointmentId == appointmentId);
        }

        public static IQueryable<Sca.Data.Entities.AppointmentSpecialty> ByWorkPositionId(this IQueryable<Sca.Data.Entities.AppointmentSpecialty> queryable, int workPositionId)
        {
            return queryable.Where(q => q.WorkPositionId == workPositionId);
        }

        #endregion

    }
}
