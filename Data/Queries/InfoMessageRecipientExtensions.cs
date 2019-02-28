using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class InfoMessageRecipientExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.InfoMessageRecipient GetByKey(this IQueryable<Sca.Data.Entities.InfoMessageRecipient> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.InfoMessageRecipient> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.InfoMessageRecipient> GetByKeyAsync(this IQueryable<Sca.Data.Entities.InfoMessageRecipient> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.InfoMessageRecipient> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.InfoMessageRecipient> ByInfoMessageIdReceivedUserId(this IQueryable<Sca.Data.Entities.InfoMessageRecipient> queryable, int infoMessageId, bool received, int userId)
        {
            return queryable.Where(q => q.InfoMessageId == infoMessageId
                && q.Received == received
                    && q.UserId == userId);
            }

            public static IQueryable<Sca.Data.Entities.InfoMessageRecipient> ByInfoMessageId(this IQueryable<Sca.Data.Entities.InfoMessageRecipient> queryable, int infoMessageId)
            {
                return queryable.Where(q => q.InfoMessageId == infoMessageId);
            }

            public static IQueryable<Sca.Data.Entities.InfoMessageRecipient> ByUserId(this IQueryable<Sca.Data.Entities.InfoMessageRecipient> queryable, int userId)
            {
                return queryable.Where(q => q.UserId == userId);
            }

            #endregion

        }
    }
