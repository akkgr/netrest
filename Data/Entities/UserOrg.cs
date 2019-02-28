using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class UserOrg
    {
        public UserOrg()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public bool? CanAdd { get; set; }

        public bool? CanDelete { get; set; }

        public bool? CanEdit { get; set; }

        public bool? CanExport { get; set; }

        public bool? CanPrint { get; set; }

        public bool? CanDoSpecial { get; set; }

        public bool? Supervisor { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual User User { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        #endregion

    }
}
