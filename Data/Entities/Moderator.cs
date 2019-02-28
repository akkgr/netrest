using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Moderator
    {
        public Moderator()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public bool IsEmployee { get; set; }

        public bool IsUser { get; set; }

        public int? WorkGroupId { get; set; }

        public int? AppointmentId { get; set; }

        public int? EmployeeId { get; set; }

        public int? UserId { get; set; }

        public string FullName { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Appointment Appointment { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual User User { get; set; }

        public virtual WorkGroup WorkGroup { get; set; }

        #endregion

    }
}
