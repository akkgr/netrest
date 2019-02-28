using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class AssignmentUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int OwnerId { get; set; }

        public string Subject { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int ScheduleType { get; set; }

        public string RecurrenceInfo { get; set; }

        public string Description { get; set; }

        public int ResponsibleId { get; set; }

        public string Remarks { get; set; }

        public string Result { get; set; }

        public decimal Progress { get; set; }

        public bool Completed { get; set; }

        public bool HasPermission { get; set; }

        public int? ClientId { get; set; }

        public int? IntakeId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
