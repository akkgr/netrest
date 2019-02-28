using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class AssetCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int? InvoiceTypeId { get; set; }

        public string InvoiceNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public string AssetNo { get; set; }

        public string Description { get; set; }

        public string Barcode { get; set; }

        public string AssetCode { get; set; }

        public bool? Warehouse { get; set; }

        public string Supplier { get; set; }

        public Byte[] Photo { get; set; }

        public int? RankId { get; set; }

        public int? PersonType { get; set; }

        public int? EmployeeId { get; set; }

        public int? ClientId { get; set; }

        public int? IntakeId { get; set; }

        public string EmployeeName { get; set; }

        public DateTime? ChargeDate { get; set; }

        public int? FirstOrgTreeNodeId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int UserId { get; set; }

        public int? AssetTypeId { get; set; }

        public bool? Disposed { get; set; }

        #endregion

    }
}
