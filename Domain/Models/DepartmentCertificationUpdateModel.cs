using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DepartmentCertificationUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int DepartmentId { get; set; }

        public int CertificationId { get; set; }

        public DateTime? CertificationStart { get; set; }

        public DateTime? CertificationEnd { get; set; }

        #endregion

    }
}
