using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ReferralCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int? ClientId { get; set; }

        public int? IntakeId { get; set; }

        public int? NewIntakeId { get; set; }

        public int FromOrgId { get; set; }

        public int? ToOrgId { get; set; }

        public int FromUserId { get; set; }

        public int? ToUserId { get; set; }

        public DateTime DateSend { get; set; }

        public DateTime? DateReceived { get; set; }

        public int? ReferralLevelId { get; set; }

        public string Files { get; set; }

        public string Request { get; set; }

        public bool Cancelled { get; set; }

        public string CancelReason { get; set; }

        #endregion

    }
}
