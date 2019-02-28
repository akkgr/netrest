using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Certification
    {
        public Certification()
        {
            #region Generated Constructor
            DepartmentCertifications = new HashSet<DepartmentCertification>();
            CertificationProcedures = new HashSet<CertificationProcedure>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<DepartmentCertification> DepartmentCertifications { get; set; }

        public virtual ICollection<CertificationProcedure> CertificationProcedures { get; set; }

        #endregion

    }
}
