using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserClaimReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int UserId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        #endregion

    }
}
