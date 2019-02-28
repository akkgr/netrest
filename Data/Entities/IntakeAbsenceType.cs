using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class IntakeAbsenceType
    {
        public IntakeAbsenceType()
        {
            #region Generated Constructor
            TypeIntakeAbsences = new HashSet<IntakeAbsence>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int Absence { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<IntakeAbsence> TypeIntakeAbsences { get; set; }

        #endregion

    }
}
