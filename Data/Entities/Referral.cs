using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Referral
    {
        public Referral()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

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

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Client Client { get; set; }

        public virtual Intake Intake { get; set; }

        public virtual Intake NewIntake { get; set; }

        public virtual OrgTreeNode FromOrgOrgTreeNode { get; set; }

        public virtual OrgTreeNode ToOrgOrgTreeNode { get; set; }

        public virtual ReferralLevel ReferralLevel { get; set; }

        public virtual User FromUser { get; set; }

        public virtual User ToUser { get; set; }

        #endregion

    }
}
