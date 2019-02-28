using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DepartmentCertification
    {
        public DepartmentCertification()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int DepartmentId { get; set; }

        public int CertificationId { get; set; }

        public DateTime? CertificationStart { get; set; }

        public DateTime? CertificationEnd { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Certification Certification { get; set; }

        public virtual Department Department { get; set; }

        #endregion

    }
}
