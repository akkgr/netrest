using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class PhoneBookEntryExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.PhoneBookEntry GetByKey(this IQueryable<Sca.Data.Entities.PhoneBookEntry> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.PhoneBookEntry> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.PhoneBookEntry> GetByKeyAsync(this IQueryable<Sca.Data.Entities.PhoneBookEntry> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.PhoneBookEntry> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.PhoneBookEntry> ByDocRankId(this IQueryable<Sca.Data.Entities.PhoneBookEntry> queryable, int docRankId)
        {
            return queryable.Where(q => q.DocRankId == docRankId);
        }

        public static IQueryable<Sca.Data.Entities.PhoneBookEntry> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.PhoneBookEntry> queryable, int orgTreeNodeId)
        {
            return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
        }

        public static IQueryable<Sca.Data.Entities.PhoneBookEntry> ByUserId(this IQueryable<Sca.Data.Entities.PhoneBookEntry> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
