using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class CertificationProcedureReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int CertificationId { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }

        public string Scope { get; set; }

        public string Involved { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Byte[] RowVersion { get; set; }

        public int? PreviousVersion { get; set; }

        #endregion

    }
}
