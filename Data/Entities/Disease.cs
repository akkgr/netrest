using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Disease
    {
        public Disease()
        {
            #region Generated Constructor
            Patients = new HashSet<Patient>();
            SecondPatients = new HashSet<Patient>();
            ThirdPatients = new HashSet<Patient>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Patient> Patients { get; set; }

        public virtual ICollection<Patient> SecondPatients { get; set; }

        public virtual ICollection<Patient> ThirdPatients { get; set; }

        #endregion

    }
}
