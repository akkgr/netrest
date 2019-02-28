using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sca.Data.Queries
{
    public static partial class CardExtensions
    {
        #region Generated Extensions
        public static Sca.Data.Entities.Card GetByKey(this IQueryable<Sca.Data.Entities.Card> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Card> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static Task<Sca.Data.Entities.Card> GetByKeyAsync(this IQueryable<Sca.Data.Entities.Card> queryable, int id)
        {
            if (queryable is DbSet<Sca.Data.Entities.Card> dbSet)
                return dbSet.FindAsync(id);

            return queryable.FirstOrDefaultAsync(q => q.Id == id);
        }

        public static IQueryable<Sca.Data.Entities.Card> ByCardValuesDateInEndDatePhotoRowVersionStartDateUserIdVisibleToEmployeeCardTypeIdOrgTreeNodeIdRankId(this IQueryable<Sca.Data.Entities.Card> queryable, string cardValues, DateTime? dateIn, DateTime? endDate, Byte[] photo, Byte[] rowVersion, DateTime? startDate, int userId, bool visibleToEmployee, int cardTypeId, int? orgTreeNodeId, int rankId)
        {
            return queryable.Where(q => (q.CardValues == cardValues || (cardValues == null && q.CardValues == null))
                && (q.DateIn == dateIn || (dateIn == null && q.DateIn == null))
                    && (q.EndDate == endDate || (endDate == null && q.EndDate == null))
                        && (q.Photo == photo || (photo == null && q.Photo == null))
                            && (q.RowVersion == rowVersion || (rowVersion == null && q.RowVersion == null))
                                && (q.StartDate == startDate || (startDate == null && q.StartDate == null))
                                    && q.UserId == userId
                                        && q.VisibleToEmployee == visibleToEmployee
                                            && q.CardTypeId == cardTypeId
                                                && (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null))
                                                    && q.RankId == rankId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Card> ByCardTypeId(this IQueryable<Sca.Data.Entities.Card> queryable, int cardTypeId)
                                            {
                                                return queryable.Where(q => q.CardTypeId == cardTypeId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Card> ByRankId(this IQueryable<Sca.Data.Entities.Card> queryable, int rankId)
                                            {
                                                return queryable.Where(q => q.RankId == rankId);
                                            }

                                            public static IQueryable<Sca.Data.Entities.Card> ByOrgTreeNodeId(this IQueryable<Sca.Data.Entities.Card> queryable, int? orgTreeNodeId)
                                            {
                                                return queryable.Where(q => (q.OrgTreeNodeId == orgTreeNodeId || (orgTreeNodeId == null && q.OrgTreeNodeId == null)));
                                            }

                                            public static IQueryable<Sca.Data.Entities.Card> ByUserId(this IQueryable<Sca.Data.Entities.Card> queryable, int userId)
                                            {
                                                return queryable.Where(q => q.UserId == userId);
                                            }

                                            #endregion

                                        }
                                    }
