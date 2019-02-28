using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Budget
    {
        public Budget()
        {
            #region Generated Constructor
            #endregion
        }

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

        #region Generated Relationships
        public virtual ActivityCode ActivityCode1 { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        #endregion

    }
}
