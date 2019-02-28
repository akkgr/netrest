using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DepartmentCertificationReadModel
    {
        #region Generated Properties
        public int DepartmentId { get; set; }

        public int CertificationId { get; set; }

        public DateTime? CertificationStart { get; set; }

        public DateTime? CertificationEnd { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
