using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class FileLinkExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.FileLink GetByKey(this IQueryable<Sca.Data.Entities.FileLink> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.FileLink> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.FileLink> GetByKeyAsync(this IQueryable<Sca.Data.Entities.FileLink> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.FileLink> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.FileLink> ByEntityIdEntityType(this IQueryable<Sca.Data.Entities.FileLink> queryable, int entityId, string entityType)
        {
            return queryable.Where(q => q.EntityId == entityId
                && q.EntityType == entityType);
        }

        public static IQueryable<Sca.Data.Entities.FileLink> ByTypeId(this IQueryable<Sca.Data.Entities.FileLink> queryable, int? typeId)
        {
            return queryable.Where(q => (q.TypeId == typeId || (typeId == null && q.TypeId == null)));
        }

        public static IQueryable<Sca.Data.Entities.FileLink> ByFileDataId(this IQueryable<Sca.Data.Entities.FileLink> queryable, int fileDataId)
        {
            return queryable.Where(q => q.FileDataId == fileDataId);
        }

        #endregion

    }
}
