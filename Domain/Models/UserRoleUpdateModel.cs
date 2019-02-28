using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserRoleUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int UserId { get; set; }

        public int RoleId { get; set; }

        #endregion

    }
}
