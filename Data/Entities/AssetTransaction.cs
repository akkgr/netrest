using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class AssetTransaction
    {
        public AssetTransaction()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

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

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Asset Asset { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }

        public virtual OrgTreeNode OrgFromOrgTreeNode { get; set; }

        public virtual OrgTreeNode OrgToOrgTreeNode { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
