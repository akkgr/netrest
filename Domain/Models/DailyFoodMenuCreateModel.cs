using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DailyFoodMenuCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public DateTime MenuDate { get; set; }

        public int FoodMenuId { get; set; }

        public int OrgTreeNodeId { get; set; }

        #endregion

    }
}
