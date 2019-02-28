using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class MedicalExpenseReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int InsurerId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public decimal Discount { get; set; }

        public decimal Retention10 { get; set; }

        public decimal Mtpy { get; set; }

        public decimal Tax8 { get; set; }

        public decimal Tax4 { get; set; }

        public decimal InitialAmount { get; set; }

        public decimal RetentionIns { get; set; }

        public decimal RetentionDoy { get; set; }

        public decimal FinalAmount { get; set; }

        public decimal? Rebate { get; set; }

        public decimal? Clawback { get; set; }

        public DateTime? ReceiptDate { get; set; }

        public bool Collected { get; set; }

        #endregion

    }
}
