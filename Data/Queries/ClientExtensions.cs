using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ClientExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Client GetByKey(this IQueryable<Sca.Data.Entities.Client> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Client> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Client> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Client> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Client> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.Client GetByBarCode(this IQueryable<Sca.Data.Entities.Client> queryable, string barCode)
        {
            return queryable.FirstOrDefault(q => (q.BarCode == barCode || (barCode == null && q.BarCode == null)));
        }

        public static Task<Sca.Data.Entities.Client> GetByBarCodeAsync(this IQueryable<Sca.Data.Entities.Client> queryable, string barCode)
        {
            return queryable.FirstOrDefaultAsync(q => (q.BarCode == barCode || (barCode == null && q.BarCode == null)));
        }

        public static IQueryable<Sca.Data.Entities.Client> ByActive(this IQueryable<Sca.Data.Entities.Client> queryable, int? active)
        {
            return queryable.Where(q => (q.Active == active || (active == null && q.Active == null)));
        }

        public static IQueryable<Sca.Data.Entities.Client> ByEducationId(this IQueryable<Sca.Data.Entities.Client> queryable, int? educationId)
        {
            return queryable.Where(q => (q.EducationId == educationId || (educationId == null && q.EducationId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Client> ByEKOId(this IQueryable<Sca.Data.Entities.Client> queryable, int? eKOId)
        {
            return queryable.Where(q => (q.EKOId == eKOId || (eKOId == null && q.EKOId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Client> ByIncomeId(this IQueryable<Sca.Data.Entities.Client> queryable, int? incomeId)
        {
            return queryable.Where(q => (q.IncomeId == incomeId || (incomeId == null && q.IncomeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Client> ByInsurerId(this IQueryable<Sca.Data.Entities.Client> queryable, int? insurerId)
        {
            return queryable.Where(q => (q.InsurerId == insurerId || (insurerId == null && q.InsurerId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Client> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Client> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.Client> ByRegisterAreaId(this IQueryable<Sca.Data.Entities.Client> queryable, int? registerAreaId)
        {
            return queryable.Where(q => (q.RegisterAreaId == registerAreaId || (registerAreaId == null && q.RegisterAreaId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Client> ByStayAreaId(this IQueryable<Sca.Data.Entities.Client> queryable, int? stayAreaId)
        {
            return queryable.Where(q => (q.StayAreaId == stayAreaId || (stayAreaId == null && q.StayAreaId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Client> ByUserId(this IQueryable<Sca.Data.Entities.Client> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static IQueryable<Sca.Data.Entities.Client> ByMaritalStatusId(this IQueryable<Sca.Data.Entities.Client> queryable, int? maritalStatusId)
        {
            return queryable.Where(q => (q.MaritalStatusId == maritalStatusId || (maritalStatusId == null && q.MaritalStatusId == null)));
        }

        #endregion

    }
}
