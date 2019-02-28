using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Specialty
    {
        public Specialty()
        {
            #region Generated Constructor
            Employees = new HashSet<Employee>();
            Applicants = new HashSet<Applicant>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Applicant> Applicants { get; set; }

        #endregion

    }
}
