using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Presence
    {
        public Presence()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public DateTime EntryTime { get; set; }

        public DateTime? ExitTime { get; set; }

        public string Remarks { get; set; }

        public string ComputerInfo { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Employee Employee { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        #endregion

    }
}
