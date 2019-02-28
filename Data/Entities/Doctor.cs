using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Doctor
    {
        public Doctor()
        {
            #region Generated Constructor
            TreatmentMedecines = new HashSet<TreatmentMedecine>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<TreatmentMedecine> TreatmentMedecines { get; set; }

        #endregion

    }
}
