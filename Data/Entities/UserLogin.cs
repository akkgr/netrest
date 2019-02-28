using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class UserLogin
    {
        public UserLogin()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int UserId { get; set; }

        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        #endregion

        #region Generated Relationships
        public virtual User User { get; set; }

        #endregion

    }
}
