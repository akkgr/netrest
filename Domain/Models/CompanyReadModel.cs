using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class CompanyReadModel
        : EntityReadModel
    {
        #region Generated Properties
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

        #endregion

    }
}
