using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class NodeToNode
    {
        public NodeToNode()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int ParentNode { get; set; }

        public int ChildNode { get; set; }

        public int UserId { get; set; }

        public bool Invoice { get; set; }

        #endregion

        #region Generated Relationships
        public virtual OrgTreeNode ParentNodeOrgTreeNode { get; set; }

        public virtual OrgTreeNode ChildNodeOrgTreeNode { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
