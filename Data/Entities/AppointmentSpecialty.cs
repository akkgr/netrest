using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class AppointmentSpecialty
    {
        public AppointmentSpecialty()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int AppointmentId { get; set; }

        public int WorkPositionId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Appointment Appointment { get; set; }

        public virtual WorkPosition WorkPosition { get; set; }

        #endregion

    }
}
