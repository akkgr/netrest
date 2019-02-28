using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ReferralLevel
    {
        public ReferralLevel()
        {
            #region Generated Constructor
            Referrals = new HashSet<Referral>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Referral> Referrals { get; set; }

        #endregion

    }
}
