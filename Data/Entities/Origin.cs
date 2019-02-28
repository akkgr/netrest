using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Origin
    {
        public Origin()
        {
            #region Generated Constructor
            ItemTransactions = new HashSet<ItemTransaction>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<ItemTransaction> ItemTransactions { get; set; }

        #endregion

    }
}
