using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Document
    {
        public Document()
        {
            #region Generated Constructor
            DocDocDocGroups = new HashSet<DocDocGroup>();
            DocDocUsers = new HashSet<DocUser>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

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

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<DocDocGroup> DocDocDocGroups { get; set; }

        public virtual DocRank RankDocRank { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<DocUser> DocDocUsers { get; set; }

        #endregion

    }
}
