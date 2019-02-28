using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class FoodMenu
    {
        public FoodMenu()
        {
            #region Generated Constructor
            DailyFoodMenus = new HashSet<DailyFoodMenu>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<DailyFoodMenu> DailyFoodMenus { get; set; }

        #endregion

    }
}
