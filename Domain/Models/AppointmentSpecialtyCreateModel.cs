using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class AppointmentSpecialtyCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int AppointmentId { get; set; }

        public int WorkPositionId { get; set; }

        #endregion

    }
}
