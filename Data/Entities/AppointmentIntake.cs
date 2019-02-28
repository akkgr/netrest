using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class AppointmentIntake
    {
        public AppointmentIntake()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int AppointmentId { get; set; }

        public bool IsIntake { get; set; }

        public int? IntakeId { get; set; }

        public bool IsClient { get; set; }

        public int? ClientId { get; set; }

        public string FullName { get; set; }

        public int? RankId { get; set; }

        public bool Billed { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Appointment Appointment { get; set; }

        public virtual Client Client { get; set; }

        public virtual DocRank RankDocRank { get; set; }

        public virtual Intake Intake { get; set; }

        #endregion

    }
}
