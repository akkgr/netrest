using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class InvoiceType
    {
        public InvoiceType()
        {
            #region Generated Constructor
            Invoices = new HashSet<Invoice>();
            Assets = new HashSet<Asset>();
            AssetTransactions = new HashSet<AssetTransaction>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }

        public virtual ICollection<AssetTransaction> AssetTransactions { get; set; }

        #endregion

    }
}
