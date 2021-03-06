using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class AssetTransactionUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int AssetId { get; set; }

        public int? InvoiceTypeId { get; set; }

        public string InvoiceNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public string Remarks { get; set; }

        public int? OrgFrom { get; set; }

        public int? OrgTo { get; set; }

        public bool? Pending { get; set; }

        public bool? Disposed { get; set; }

        public int? EmployeeId { get; set; }

        public string Employee { get; set; }

        public DateTime? ChargeDate { get; set; }

        public int UserId { get; set; }

        #endregion

    }
}
