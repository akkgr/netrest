using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            #region Generated Constructor
            Invoices = new HashSet<Invoice>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int Act { get; set; }

        public bool IsCash { get; set; }

        public int CustomerAct { get; set; }

        public int ProviderAct { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Invoice> Invoices { get; set; }

        #endregion

    }
}
