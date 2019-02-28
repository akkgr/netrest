using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ActivityCode
    {
        public ActivityCode()
        {
            #region Generated Constructor
            Budgets = new HashSet<Budget>();
            Invoices = new HashSet<Invoice>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Budget> Budgets { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        #endregion

    }
}
