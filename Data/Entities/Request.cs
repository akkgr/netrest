using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Request
    {
        public Request()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public int RequestTypeId { get; set; }

        public string Remarks { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public int? DaysEmployee { get; set; }

        public int? DaysSupervisor { get; set; }

        public int? ForYear { get; set; }

        public DateTime? DateApplied { get; set; }

        public bool Pending { get; set; }

        public bool Approved { get; set; }

        public int? ApprovedById { get; set; }

        public DateTime? DateApproved { get; set; }

        public string Answer { get; set; }

        public int Category { get; set; }

        public bool Received { get; set; }

        public DateTime? Deadline { get; set; }

        public int? AssignmentId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Assignment Assignment { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual RequestType RequestType { get; set; }

        public virtual User EmployeeUser { get; set; }

        public virtual User ApprovedByUser { get; set; }

        #endregion

    }
}
