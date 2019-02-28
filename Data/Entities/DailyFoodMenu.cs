using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DailyFoodMenu
    {
        public DailyFoodMenu()
        {
            #region Generated Constructor
            FoodMenuProductTransactions = new HashSet<ProductTransaction>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime MenuDate { get; set; }

        public int FoodMenuId { get; set; }

        public int OrgTreeNodeId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<ProductTransaction> FoodMenuProductTransactions { get; set; }

        public virtual FoodMenu FoodMenu { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        #endregion

    }
}
