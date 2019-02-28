using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class DailyFoodMenuExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.DailyFoodMenu GetByKey(this IQueryable<Sca.Data.Entities.DailyFoodMenu> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DailyFoodMenu> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.DailyFoodMenu> GetByKeyAsync(this IQueryable<Sca.Data.Entities.DailyFoodMenu> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.DailyFoodMenu> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static Sca.Data.Entities.DailyFoodMenu GetByMenuDateFoodMenuIdOrgTreeNodeId(this IQueryable<Sca.Data.Entities.DailyFoodMenu> queryable, DateTime menuDate, int foodMenuId, int orgTreeNodeId)
        {
            return queryable.FirstOrDefault(q => q.MenuDate == menuDate
                && q.FoodMenuId == foodMenuId
                    && q.OrgTreeNodeId == orgTreeNodeId);
            }

            public static Task<Sca.Data.Entities.DailyFoodMenu> GetByMenuDateFoodMenuIdOrgTreeNodeIdAsync(this IQueryable<Sca.Data.Entities.DailyFoodMenu> queryable, DateTime menuDate, int foodMenuId, int orgTreeNodeId)
            {
                return queryable.FirstOrDefaultAsync(q => q.MenuDate == menuDate
                    && q.FoodMenuId == foodMenuId
                        && q.OrgTreeNodeId == orgTreeNodeId);
                }

                public static IQueryable<Sca.Data.Entities.DailyFoodMenu> ByFoodMenuId(this IQueryable<Sca.Data.Entities.DailyFoodMenu> queryable, int foodMenuId)
                {
                    return queryable.Where(q => q.FoodMenuId == foodMenuId);
                }

                public static IQueryable<Sca.Data.Entities.DailyFoodMenu> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.DailyFoodMenu> queryable, int orgTreeNodeId)
                {
                    return queryable.Where(q => q.OrgTreeNodeId == orgTreeNodeId);
                }

                #endregion

            }
        }
