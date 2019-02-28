using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class LeaveCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public int BsenceTypeId { get; set; }

        public int Year { get; set; }

        public int? Total { get; set; }

        public int? Used { get; set; }

        public int? Remain { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
