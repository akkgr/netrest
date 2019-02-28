using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserClaimReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int UserId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        #endregion

    }
}
