using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class PatientExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Patient GetByKey(this IQueryable<Sca.Data.Entities.Patient> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Patient> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Patient> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Patient> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Patient> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Patient> ByDiseaseId(this IQueryable<Sca.Data.Entities.Patient> queryable, int? diseaseId)
        {
            return queryable.Where(q => (q.DiseaseId == diseaseId || (diseaseId == null && q.DiseaseId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Patient> BySecondDiseaseId(this IQueryable<Sca.Data.Entities.Patient> queryable, int? secondDiseaseId)
        {
            return queryable.Where(q => (q.SecondDiseaseId == secondDiseaseId || (secondDiseaseId == null && q.SecondDiseaseId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Patient> ByThirdDiseaseId(this IQueryable<Sca.Data.Entities.Patient> queryable, int? thirdDiseaseId)
        {
            return queryable.Where(q => (q.ThirdDiseaseId == thirdDiseaseId || (thirdDiseaseId == null && q.ThirdDiseaseId == null)));
        }

        #endregion

    }
}
