using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class TreatmentUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int Sn { get; set; }

        public int? IntakeId { get; set; }

        public int? ClientId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Njectable { get; set; }

        public string NjectableNote { get; set; }

        public string Nxiety { get; set; }

        public string NxietyNote { get; set; }

        public string NtenseΑnxiety { get; set; }

        public string NtenseΑnxietyNote { get; set; }

        public string Remarks { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
