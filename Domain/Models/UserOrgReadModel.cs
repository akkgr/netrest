using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class UserOrgReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public bool? CanAdd { get; set; }

        public bool? CanDelete { get; set; }

        public bool? CanEdit { get; set; }

        public bool? CanExport { get; set; }

        public bool? CanPrint { get; set; }

        public bool? CanDoSpecial { get; set; }

        public bool? Supervisor { get; set; }

        #endregion

    }
}
