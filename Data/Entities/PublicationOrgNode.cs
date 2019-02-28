using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class PublicationOrgNode
    {
        public PublicationOrgNode()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int PublicationId { get; set; }

        public int OrgNodeId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual OrgNode OrgNode { get; set; }

        public virtual Publication Publication { get; set; }

        #endregion

    }
}
