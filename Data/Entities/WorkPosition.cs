using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class WorkPosition
    {
        public WorkPosition()
        {
            #region Generated Constructor
            Candidates = new HashSet<Candidate>();
            PositionEmployees = new HashSet<Employee>();
            AppointmentSpecialties = new HashSet<AppointmentSpecialty>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Candidate> Candidates { get; set; }

        public virtual ICollection<Employee> PositionEmployees { get; set; }

        public virtual ICollection<AppointmentSpecialty> AppointmentSpecialties { get; set; }

        #endregion

    }
}
