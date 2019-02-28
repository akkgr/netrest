using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class BudgetCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int OrgTreeNodeId { get; set; }

        public int FinanceYear { get; set; }

        public int ActivityCodeId { get; set; }

        public string ActivityCode { get; set; }

        public decimal BudgetAmount { get; set; }

        public decimal AccountAmount { get; set; }

        public decimal UsedRate { get; set; }

        public decimal RefAmount { get; set; }

        #endregion

    }
}
