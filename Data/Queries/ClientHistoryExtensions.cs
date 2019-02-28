using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class ClientHistoryExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.ClientHistory GetByKey(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ClientHistory> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.ClientHistory> GetByKeyAsync(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.ClientHistory> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByClientid(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int clientid)
        {
            return queryable.Where(q => q.Clientid == clientid);
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByActive(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int? active)
        {
            return queryable.Where(q => (q.Active == active || (active == null && q.Active == null)));
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByEducationId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int? educationId)
        {
            return queryable.Where(q => (q.EducationId == educationId || (educationId == null && q.EducationId == null)));
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByEKOId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int? eKOId)
        {
            return queryable.Where(q => (q.EKOId == eKOId || (eKOId == null && q.EKOId == null)));
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByIncomeId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int? incomeId)
        {
            return queryable.Where(q => (q.IncomeId == incomeId || (incomeId == null && q.IncomeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByInsurerId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int? insurerId)
        {
            return queryable.Where(q => (q.InsurerId == insurerId || (insurerId == null && q.InsurerId == null)));
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByRegisterAreaId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int? registerAreaId)
        {
            return queryable.Where(q => (q.RegisterAreaId == registerAreaId || (registerAreaId == null && q.RegisterAreaId == null)));
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByStayAreaId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int? stayAreaId)
        {
            return queryable.Where(q => (q.StayAreaId == stayAreaId || (stayAreaId == null && q.StayAreaId == null)));
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByUserId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static IQueryable<Sca.Data.Entities.ClientHistory> ByMaritalStatusId(this IQueryable<Sca.Data.Entities.ClientHistory> queryable, int? maritalStatusId)
        {
            return queryable.Where(q => (q.MaritalStatusId == maritalStatusId || (maritalStatusId == null && q.MaritalStatusId == null)));
        }

        #endregion

    }
}
