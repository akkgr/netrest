using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CandidateExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Candidate GetByKey(this IQueryable<Sca.Data.Entities.Candidate> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Candidate> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Candidate> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Candidate> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Candidate> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Candidate> ByInterestId(this IQueryable<Sca.Data.Entities.Candidate> queryable, int? interestId)
        {
            return queryable.Where(q => (q.InterestId == interestId || (interestId == null && q.InterestId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Candidate> ByRankId(this IQueryable<Sca.Data.Entities.Candidate> queryable, int? rankId)
        {
            return queryable.Where(q => (q.RankId == rankId || (rankId == null && q.RankId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Candidate> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Candidate> queryable, int? orgTreeNodeId)
        {
            return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Candidate> ByUserId(this IQueryable<Sca.Data.Entities.Candidate> queryable, int? userId)
        {
            return queryable.Where(q => (q.UserId == userId || (userId == null && q.UserId == null)));
        }

        public static IQueryable<Sca.Data.Entities.Candidate> ByWorkPositionId(this IQueryable<Sca.Data.Entities.Candidate> queryable, int? workPositionId)
        {
            return queryable.Where(q => (q.WorkPositionId == workPositionId || (workPositionId == null && q.WorkPositionId == null)));
        }

        #endregion

    }
}
