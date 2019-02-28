using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ProductTransactionReadModel
        : EntityReadModel
    {
        #region Generated Properties
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

        #endregion

    }
}
