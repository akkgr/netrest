using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class IntakeAbsence
    {
        public IntakeAbsence()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int IntakeId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int TypeId { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Intake Intake { get; set; }

        public virtual IntakeAbsenceType TypeIntakeAbsenceType { get; set; }

        #endregion

    }
}
