using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class PresenceUpdateModel
    {
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

    }
}
