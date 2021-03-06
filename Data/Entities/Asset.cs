using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Asset
    {
        public Asset()
        {
            #region Generated Constructor
            AssetTransactions = new HashSet<AssetTransaction>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

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

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual AssetType AssetType { get; set; }

        public virtual Client Client { get; set; }

        public virtual DocRank RankDocRank { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Intake Intake { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual OrgTreeNode FirstOrgTreeNode { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<AssetTransaction> AssetTransactions { get; set; }

        #endregion

    }
}
