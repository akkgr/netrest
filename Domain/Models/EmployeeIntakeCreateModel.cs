using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class EmployeeIntakeCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int EmployeeId { get; set; }

        public int IntakeId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        #endregion

    }
}
