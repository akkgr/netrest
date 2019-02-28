using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Publication
    {
        public Publication()
        {
            #region Generated Constructor
            PublicationOrgNodes = new HashSet<PublicationOrgNode>();
            PublicationDivisions = new HashSet<PublicationDivision>();
            CertificationProcedurePublications = new HashSet<CertificationProcedurePublication>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int SerialNumber { get; set; }

        public DateTime RegisterDate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int RankId { get; set; }

        public bool IsActive { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<PublicationOrgNode> PublicationOrgNodes { get; set; }

        public virtual ICollection<PublicationDivision> PublicationDivisions { get; set; }

        public virtual DocRank RankDocRank { get; set; }

        public virtual ICollection<CertificationProcedurePublication> CertificationProcedurePublications { get; set; }

        #endregion

    }
}
