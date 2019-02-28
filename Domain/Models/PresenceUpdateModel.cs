using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class PresenceUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int EmployeeId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public DateTime EntryTime { get; set; }

        public DateTime? ExitTime { get; set; }

        public string Remarks { get; set; }

        public string ComputerInfo { get; set; }

        #endregion

    }
}
