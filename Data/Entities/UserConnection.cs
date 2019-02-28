using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class UserConnection
    {
        public UserConnection()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string ConnectionId { get; set; }

        public DateTime? SignIn { get; set; }

        public DateTime? SignOut { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
