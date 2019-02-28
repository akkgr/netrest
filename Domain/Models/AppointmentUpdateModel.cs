using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class AppointmentUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int? AppointmentTypeId { get; set; }

        public string Subject { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public string Description { get; set; }

        public bool AllDay { get; set; }

        public int Status { get; set; }

        public string RecurrenceInfo { get; set; }

        public string ReminderInfo { get; set; }

        public int ScheduleType { get; set; }

        public bool? Cancelled { get; set; }

        public string CancelReason { get; set; }

        public bool? Occupied { get; set; }

        public int? WorkGroupId { get; set; }

        public int? RankId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int UserId { get; set; }

        public bool IsRegistry { get; set; }

        public bool NoCost { get; set; }

        public string CostRemarks { get; set; }

        public bool IsPrivate { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
