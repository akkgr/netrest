using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            #region Generated Constructor
            EmployeePayments = new HashSet<EmployeePayment>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EmployeePayment> EmployeePayments { get; set; }

        #endregion

    }
}
