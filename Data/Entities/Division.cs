using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Division
    {
        public Division()
        {
            #region Generated Constructor
            PublicationDivisions = new HashSet<PublicationDivision>();
            DepartmentDivisions = new HashSet<DepartmentDivision>();
            DivisionJobs = new HashSet<DivisionJob>();
            UserDivisions = new HashSet<UserDivision>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<PublicationDivision> PublicationDivisions { get; set; }

        public virtual ICollection<DepartmentDivision> DepartmentDivisions { get; set; }

        public virtual ICollection<DivisionJob> DivisionJobs { get; set; }

        public virtual ICollection<UserDivision> UserDivisions { get; set; }

        #endregion

    }
}
