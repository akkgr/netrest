using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class AppointmentType
    {
        public AppointmentType()
        {
            #region Generated Constructor
            Appointments = new HashSet<Appointment>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Color { get; set; }

        public decimal Cost { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Appointment> Appointments { get; set; }

        #endregion

    }
}
