using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AppointmentIntakeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.AppointmentIntake GetByKey(this IQueryable<Sca.Data.Entities.AppointmentIntake> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AppointmentIntake> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.AppointmentIntake> GetByKeyAsync(this IQueryable<Sca.Data.Entities.AppointmentIntake> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AppointmentIntake> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.AppointmentIntake> ByAppointmentIdClientIdIsClient(this IQueryable<Sca.Data.Entities.AppointmentIntake> queryable, int appointmentId, int? clientId, bool isClient)
        {
            return queryable.Where(q => q.AppointmentId == appointmentId
                && (q.ClientId == clientId || (clientId == null && q.ClientId == null))
                    && q.IsClient == isClient);
            }

            public static IQueryable<Sca.Data.Entities.AppointmentIntake> ByBilledClientIdFullNameIntakeIdIsClientIsIntakeRankIdRowVersionAppointmentId(this IQueryable<Sca.Data.Entities.AppointmentIntake> queryable, bool billed, int? clientId, string fullName, int? intakeId, bool isClient, bool isIntake, int? rankId, Byte[] rowVersion, int appointmentId)
            {
                return queryable.Where(q => q.Billed == billed
                    && (q.ClientId == clientId || (clientId == null && q.ClientId == null))
                        && (q.FullName == fullName || (fullName == null && q.FullName == null))
                            && (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null))
                                && q.IsClient == isClient
                                    && q.IsIntake == isIntake
                                        && (q.RankId == rankId || (rankId == null && q.RankId == null))
                                            && (q.RowVersion == rowVersion || (rowVersion == null && q.RowVersion == null))
                                                && q.AppointmentId == appointmentId);
                                        }

                                        public static IQueryable<Sca.Data.Entities.AppointmentIntake> ByAppointmentId(this IQueryable<Sca.Data.Entities.AppointmentIntake> queryable, int appointmentId)
                                        {
                                            return queryable.Where(q => q.AppointmentId == appointmentId);
                                        }

                                        public static IQueryable<Sca.Data.Entities.AppointmentIntake> ByClientId(this IQueryable<Sca.Data.Entities.AppointmentIntake> queryable, int? clientId)
                                        {
                                            return queryable.Where(q => (q.ClientId == clientId || (clientId == null && q.ClientId == null)));
                                        }

                                        public static IQueryable<Sca.Data.Entities.AppointmentIntake> ByRankId(this IQueryable<Sca.Data.Entities.AppointmentIntake> queryable, int? rankId)
                                        {
                                            return queryable.Where(q => (q.RankId == rankId || (rankId == null && q.RankId == null)));
                                        }

                                        public static IQueryable<Sca.Data.Entities.AppointmentIntake> ByIntakeId(this IQueryable<Sca.Data.Entities.AppointmentIntake> queryable, int? intakeId)
                                        {
                                            return queryable.Where(q => (q.IntakeId == intakeId || (intakeId == null && q.IntakeId == null)));
                                        }

                                        #endregion

                                    }
                                }
