using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ItemTransaction
    {
        public ItemTransaction()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime TransactionDate { get; set; }

        public int ItemId { get; set; }

        public string Title { get; set; }

        public int PackagingId { get; set; }

        public int CategoryId { get; set; }

        public int UnitId { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public string TransactionCause { get; set; }

        public int? ClientId { get; set; }

        public int? IntakeId { get; set; }

        public DateTime? Xpiration { get; set; }

        public int? OriginId { get; set; }

        public string Remarks { get; set; }

        public decimal TransactionType { get; set; }

        public string BarCode { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public bool Processed { get; set; }

        public string Doctor { get; set; }

        public string Prescription { get; set; }

        public string Invoice { get; set; }

        public decimal? RunningTotal { get; set; }

        public bool TransferDestroy { get; set; }

        public bool InternalUse { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Client Client { get; set; }

        public virtual Intake Intake { get; set; }

        public virtual Item Item { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual Origin Origin { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
