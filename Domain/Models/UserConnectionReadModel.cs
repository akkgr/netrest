using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserConnectionReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public string UserName { get; set; }

        public string FullName { get; set; }

        public string ConnectionId { get; set; }

        public DateTime? SignIn { get; set; }

        public DateTime? SignOut { get; set; }

        #endregion

    }
}
