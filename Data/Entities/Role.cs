using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Role
    {
        public Role()
        {
            #region Generated Constructor
            UserRoles = new HashSet<UserRole>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<UserRole> UserRoles { get; set; }

        #endregion

    }
}
