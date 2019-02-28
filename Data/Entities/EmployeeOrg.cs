using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class EmployeeOrg
    {
        public EmployeeOrg()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int OrgTreeNodeId { get; set; }

        public int EmployeeId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Employee Employee { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        #endregion

    }
}
