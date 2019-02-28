using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ProductTransaction
    {
        public ProductTransaction()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime ProductDate { get; set; }

        public string Product { get; set; }

        public int? FoodMenuId { get; set; }

        public int? ClientId { get; set; }

        public int? IntakeId { get; set; }

        public string TransactionCause { get; set; }

        public decimal? Quantity { get; set; }

        public string Remarks { get; set; }

        public decimal? ItemId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public bool TransferDestroy { get; set; }

        public bool InternalUse { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Client Client { get; set; }

        public virtual DailyFoodMenu FoodMenuDailyFoodMenu { get; set; }

        public virtual Intake Intake { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
