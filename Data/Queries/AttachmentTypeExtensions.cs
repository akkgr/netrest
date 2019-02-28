using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class AttachmentTypeExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.AttachmentType GetByKey(this IQueryable<Sca.Data.Entities.AttachmentType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AttachmentType> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.AttachmentType> GetByKeyAsync(this IQueryable<Sca.Data.Entities.AttachmentType> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.AttachmentType> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.AttachmentType GetByTitle(this IQueryable<Sca.Data.Entities.AttachmentType> queryable, string title)
        {
            return queryable.FirstOrDefault(q => q.Title == title);
        }

        public static Task<Sca.Data.Entities.AttachmentType> GetByTitleAsync(this IQueryable<Sca.Data.Entities.AttachmentType> queryable, string title)
        {
            return queryable.FirstOrDefaultAsync(q => q.Title == title);
        }

        #endregion

    }
}
