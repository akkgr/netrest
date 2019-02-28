using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class IntakeBenefitUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public decimal StandardAmount { get; set; }

        public decimal AbsenceAmount { get; set; }

        #endregion

    }
}
