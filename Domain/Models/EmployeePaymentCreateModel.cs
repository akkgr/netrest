using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class EmployeePaymentCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int EmployeeId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public int PaymentTypeId { get; set; }

        public DateTime RefDate { get; set; }

        public DateTime PayDate { get; set; }

        public int? Days { get; set; }

        public decimal? TotalEarn { get; set; }

        public decimal? Insurance { get; set; }

        public decimal? Fmy { get; set; }

        public decimal? Oga { get; set; }

        public decimal? TotalReserve { get; set; }

        public decimal? Total { get; set; }

        public decimal? Allowance { get; set; }

        public decimal? Nstallment { get; set; }

        public decimal? Dvance { get; set; }

        public decimal? Pay { get; set; }

        public decimal? Mployer { get; set; }

        public DateTime? Paid { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
