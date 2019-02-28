using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ClientHistoryService
    {
        public ClientHistoryService()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int ClientHistoryId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public decimal Balance { get; set; }

        public int? Active { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime LastUpdated { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ClientHistory ClientHistory { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        #endregion

    }
}
