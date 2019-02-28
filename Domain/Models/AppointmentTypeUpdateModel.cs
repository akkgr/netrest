using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class AppointmentTypeUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public string Color { get; set; }

        public decimal Cost { get; set; }

        #endregion

    }
}
