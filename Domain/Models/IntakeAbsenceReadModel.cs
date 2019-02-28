using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class IntakeAbsenceReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int IntakeId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int TypeId { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
