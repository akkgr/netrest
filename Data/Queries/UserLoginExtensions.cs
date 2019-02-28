using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class UserLoginExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.UserLogin GetByKey(this IQueryable<Sca.Data.Entities.UserLogin> queryable, int userId, string loginProvider, string providerKey)
        {
            if (queryable is DbSet<Sca.Data.Entities.UserLogin> dbSet)
                return dbSet.Find(userId, loginProvider, providerKey);

            return queryable.FirstOrDefault(q => q.UserId == userId
                && q.LoginProvider == loginProvider
                    && q.ProviderKey == providerKey);
            }

            public static Task<Sca.Data.Entities.UserLogin> GetByKeyAsync(this IQueryable<Sca.Data.Entities.UserLogin> queryable, int userId, string loginProvider, string providerKey)
            {
                if (queryable is DbSet<Sca.Data.Entities.UserLogin> dbSet)
                    return dbSet.FindAsync(userId, loginProvider, providerKey);

                return queryable.FirstOrDefaultAsync(q => q.UserId == userId
                    && q.LoginProvider == loginProvider
                        && q.ProviderKey == providerKey);
                }

                public static IQueryable<Sca.Data.Entities.UserLogin> ByUserId(this IQueryable<Sca.Data.Entities.UserLogin> queryable, int userId)
                {
                    return queryable.Where(q => q.UserId == userId);
                }

                #endregion

            }
        }
