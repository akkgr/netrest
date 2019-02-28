using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ParticipantExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Participant GetByKey(this IQueryable<Sca.Data.Entities.Participant> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Participant> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Participant> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Participant> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Participant> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Participant> ByAssignmentId(this IQueryable<Sca.Data.Entities.Participant> queryable, int assignmentId)
        {
            return queryable.Where(q => q.AssignmentId == assignmentId);
        }

        public static IQueryable<Sca.Data.Entities.Participant> ByParticipantId(this IQueryable<Sca.Data.Entities.Participant> queryable, int participantId)
        {
            return queryable.Where(q => q.ParticipantId == participantId);
        }

        #endregion

    }
}
