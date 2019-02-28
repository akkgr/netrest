using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Degree
    {
        public Degree()
        {
            #region Generated Constructor
            Applicants = new HashSet<Applicant>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Applicant> Applicants { get; set; }

        #endregion

    }
}
