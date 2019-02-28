using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserConnectionCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string ConnectionId { get; set; }

        public DateTime? SignIn { get; set; }

        public DateTime? SignOut { get; set; }

        #endregion

    }
}
