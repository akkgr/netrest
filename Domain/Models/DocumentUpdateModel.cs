using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DocumentUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public DateTime RegistrationDate { get; set; }

        public string FromTo { get; set; }

        public string Subject { get; set; }

        public int InOut { get; set; }

        public string InDocRegistration { get; set; }

        public DateTime? InDocDate { get; set; }

        public string Receipt { get; set; }

        public string Remarks { get; set; }

        public string TempRegistration { get; set; }

        public int? RankId { get; set; }

        public string Registration { get; set; }

        public int? UserId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int RegNum { get; set; }

        public string OutDocRegistration { get; set; }

        public bool Deleted { get; set; }

        #endregion

    }
}
