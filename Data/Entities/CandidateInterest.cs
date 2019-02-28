using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class CandidateInterest
    {
        public CandidateInterest()
        {
            #region Generated Constructor
            InterestCandidates = new HashSet<Candidate>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Candidate> InterestCandidates { get; set; }

        #endregion

    }
}
