using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class UserDivision
    {
        public UserDivision()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int UserId { get; set; }

        public int DivisionId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Division Division { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
