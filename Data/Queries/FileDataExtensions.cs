using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class FileDataExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.FileData GetByKey(this IQueryable<Sca.Data.Entities.FileData> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.FileData> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.FileData> GetByKeyAsync(this IQueryable<Sca.Data.Entities.FileData> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.FileData> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.FileData GetByHash(this IQueryable<Sca.Data.Entities.FileData> queryable, string hash)
        {
            return queryable.FirstOrDefault(q => (q.Hash == hash || (hash == null && q.Hash == null)));
        }

        public static Task<Sca.Data.Entities.FileData> GetByHashAsync(this IQueryable<Sca.Data.Entities.FileData> queryable, string hash)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Hash == hash || (hash == null && q.Hash == null)));
        }

        #endregion

    }
}
