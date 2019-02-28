using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class TreatmentMedecineExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.TreatmentMedecine GetByKey(this IQueryable<Sca.Data.Entities.TreatmentMedecine> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.TreatmentMedecine> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.TreatmentMedecine> GetByKeyAsync(this IQueryable<Sca.Data.Entities.TreatmentMedecine> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.TreatmentMedecine> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.TreatmentMedecine> ByDoctorId(this IQueryable<Sca.Data.Entities.TreatmentMedecine> queryable, int? doctorId)
        {
            return queryable.Where(q => (q.DoctorId == doctorId || (doctorId == null && q.DoctorId == null)));
        }

        public static IQueryable<Sca.Data.Entities.TreatmentMedecine> ByItemId(this IQueryable<Sca.Data.Entities.TreatmentMedecine> queryable, int itemId)
        {
            return queryable.Where(q => q.ItemId == itemId);
        }

        public static IQueryable<Sca.Data.Entities.TreatmentMedecine> ByTreatmentId(this IQueryable<Sca.Data.Entities.TreatmentMedecine> queryable, int treatmentId)
        {
            return queryable.Where(q => q.TreatmentId == treatmentId);
        }

        #endregion

    }
}
