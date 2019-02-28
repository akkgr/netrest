using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class BoardMinuteSignatureExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.BoardMinuteSignature GetByKey(this IQueryable<Sca.Data.Entities.BoardMinuteSignature> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.BoardMinuteSignature> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.BoardMinuteSignature> GetByKeyAsync(this IQueryable<Sca.Data.Entities.BoardMinuteSignature> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.BoardMinuteSignature> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.BoardMinuteSignature GetByBoardminuteIdBoardMemberId(this IQueryable<Sca.Data.Entities.BoardMinuteSignature> queryable, int boardminuteId, int boardMemberId)
        {
            return queryable.FirstOrDefault(q => q.BoardminuteId == boardminuteId
                && q.BoardMemberId == boardMemberId);
        }

        public static Task<Sca.Data.Entities.BoardMinuteSignature> GetByBoardminuteIdBoardMemberIdAsync(this IQueryable<Sca.Data.Entities.BoardMinuteSignature> queryable, int boardminuteId, int boardMemberId)
        {
            return queryable.FirstOrDefaultAsync(q => q.BoardminuteId == boardminuteId
                && q.BoardMemberId == boardMemberId);
        }

        public static IQueryable<Sca.Data.Entities.BoardMinuteSignature> ByBoardMemberId(this IQueryable<Sca.Data.Entities.BoardMinuteSignature> queryable, int boardMemberId)
        {
            return queryable.Where(q => q.BoardMemberId == boardMemberId);
        }

        public static IQueryable<Sca.Data.Entities.BoardMinuteSignature> ByBoardminuteId(this IQueryable<Sca.Data.Entities.BoardMinuteSignature> queryable, int boardminuteId)
        {
            return queryable.Where(q => q.BoardminuteId == boardminuteId);
        }

        #endregion

    }
}
