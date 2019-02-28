using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserLoginReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int UserId { get; set; }

        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        #endregion

    }
}
