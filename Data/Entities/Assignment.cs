using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Assignment
    {
        public Assignment()
        {
            #region Generated Constructor
            Participants = new HashSet<Participant>();
            Requests = new HashSet<Request>();
            #endregion
        }

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

        #region Generated Relationships
        public virtual ICollection<Participant> Participants { get; set; }

        public virtual ICollection<Request> Requests { get; set; }

        public virtual Client Client { get; set; }

        public virtual Intake Intake { get; set; }

        public virtual Employee OwnerEmployee { get; set; }

        public virtual Employee ResponsibleEmployee { get; set; }

        #endregion

    }
}
