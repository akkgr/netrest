using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class EmployeeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Employee GetByKey(this IQueryable<Sca.Data.Entities.Employee> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Employee> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Employee> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Employee> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Employee> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Employee GetByBarCode(this IQueryable<Sca.Data.Entities.Employee> queryable, string barCode)
        {
            return queryable.FirstOrDefault(q => (q.BarCode == barCode || (barCode == null && q.BarCode == null)));
        }

        public static Task<Sca.Data.Entities.Employee> GetByBarCodeAsync(this IQueryable<Sca.Data.Entities.Employee> queryable, string barCode)
        {
            return queryable.FirstOrDefaultAsync(q => (q.BarCode == barCode || (barCode == null && q.BarCode == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> ByContractTypeId(this IQueryable<Sca.Data.Entities.Employee> queryable, int? contractTypeId)
        {
            return queryable.Where(q => (q.ContractTypeId == contractTypeId || (contractTypeId == null && q.ContractTypeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> BySecRank(this IQueryable<Sca.Data.Entities.Employee> queryable, int? secRank)
        {
            return queryable.Where(q => (q.SecRank == secRank || (secRank == null && q.SecRank == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> ByDOYId(this IQueryable<Sca.Data.Entities.Employee> queryable, int? dOYId)
        {
            return queryable.Where(q => (q.DOYId == dOYId || (dOYId == null && q.DOYId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> ByEducationId(this IQueryable<Sca.Data.Entities.Employee> queryable, int? educationId)
        {
            return queryable.Where(q => (q.EducationId == educationId || (educationId == null && q.EducationId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> ByEmploymentTypeId(this IQueryable<Sca.Data.Entities.Employee> queryable, int? employmentTypeId)
        {
            return queryable.Where(q => (q.EmploymentTypeId == employmentTypeId || (employmentTypeId == null && q.EmploymentTypeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> ByMaritalStatusId(this IQueryable<Sca.Data.Entities.Employee> queryable, int? maritalStatusId)
        {
            return queryable.Where(q => (q.MaritalStatusId == maritalStatusId || (maritalStatusId == null && q.MaritalStatusId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> ByNationalityId(this IQueryable<Sca.Data.Entities.Employee> queryable, int? nationalityId)
        {
            return queryable.Where(q => (q.NationalityId == nationalityId || (nationalityId == null && q.NationalityId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> BySpecialtyId(this IQueryable<Sca.Data.Entities.Employee> queryable, int? specialtyId)
        {
            return queryable.Where(q => (q.SpecialtyId == specialtyId || (specialtyId == null && q.SpecialtyId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Employee> ByUserId(this IQueryable<Sca.Data.Entities.Employee> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static IQueryable<Sca.Data.Entities.Employee> ByPositionId(this IQueryable<Sca.Data.Entities.Employee> queryable, int? positionId)
        {
            return queryable.Where(q => (q.PositionId == positionId || (positionId == null && q.PositionId == null)));
        }

        #endregion

    }
}
