using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class BoardMinuteSubjectExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.BoardMinuteSubject GetByKey(this IQueryable<Sca.Data.Entities.BoardMinuteSubject> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.BoardMinuteSubject> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.BoardMinuteSubject> GetByKeyAsync(this IQueryable<Sca.Data.Entities.BoardMinuteSubject> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.BoardMinuteSubject> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.BoardMinuteSubject> ByBoardminuteId(this IQueryable<Sca.Data.Entities.BoardMinuteSubject> queryable, int boardminuteId)
        {
            return queryable.Where(q => q.BoardminuteId == boardminuteId);
        }

        #endregion

    }
}
