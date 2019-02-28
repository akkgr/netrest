using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserRoleCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int UserId { get; set; }

        public int RoleId { get; set; }

        #endregion

    }
}
