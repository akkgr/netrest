using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class TreatmentMedecineCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int TreatmentId { get; set; }

        public int ItemId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? DoctorId { get; set; }

        public string MorningMemo { get; set; }

        public decimal? MorningQuantity { get; set; }

        public string OonMemo { get; set; }

        public decimal? OonQuantity { get; set; }

        public string VeningMemo { get; set; }

        public decimal? VeningQuantity { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
