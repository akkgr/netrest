using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class AppointmentIntakeUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int AppointmentId { get; set; }

        public bool IsIntake { get; set; }

        public int? IntakeId { get; set; }

        public bool IsClient { get; set; }

        public int? ClientId { get; set; }

        public string FullName { get; set; }

        public int? RankId { get; set; }

        public bool Billed { get; set; }

        #endregion

    }
}
