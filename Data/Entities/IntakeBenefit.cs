using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class IntakeBenefit
    {
        public IntakeBenefit()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public decimal StandardAmount { get; set; }

        public decimal AbsenceAmount { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
