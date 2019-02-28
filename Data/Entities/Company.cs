using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Company
    {
        public Company()
        {
            #region Generated Constructor
            Invoices = new HashSet<Invoice>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Afm { get; set; }

        public string Activity { get; set; }

        public string Address { get; set; }

        public string Area { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public int? DoyId { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Doy Doy { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        #endregion

    }
}
