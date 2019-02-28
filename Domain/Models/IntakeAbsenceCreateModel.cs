using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class IntakeAbsenceCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int IntakeId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int TypeId { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
