using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ModeratorCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public bool IsEmployee { get; set; }

        public bool IsUser { get; set; }

        public int? WorkGroupId { get; set; }

        public int? AppointmentId { get; set; }

        public int? EmployeeId { get; set; }

        public int? UserId { get; set; }

        public string FullName { get; set; }

        #endregion

    }
}
