using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class OrgNode
    {
        public OrgNode()
        {
            #region Generated Constructor
            PublicationOrgNodes = new HashSet<PublicationOrgNode>();
            NodeOrgTreeNodes = new HashSet<OrgTreeNode>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }

        public int NodeTypeId { get; set; }

        public bool IsActive { get; set; }

        public int? ViewOrder { get; set; }

        public string AppObject { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<PublicationOrgNode> PublicationOrgNodes { get; set; }

        public virtual OrgNodeType NodeTypeOrgNodeType { get; set; }

        public virtual ICollection<OrgTreeNode> NodeOrgTreeNodes { get; set; }

        #endregion

    }
}
