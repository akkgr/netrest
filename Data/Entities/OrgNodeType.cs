using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class OrgNodeType
    {
        public OrgNodeType()
        {
            #region Generated Constructor
            NodeTypeOrgNodes = new HashSet<OrgNode>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int TreeLevel { get; set; }

        public bool UserAvailable { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<OrgNode> NodeTypeOrgNodes { get; set; }

        #endregion

    }
}
