using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class CardEmployee
    {
        public CardEmployee()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CardId { get; set; }

        public int EmployeeId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Card Card { get; set; }

        public virtual Employee Employee { get; set; }

        #endregion

    }
}
