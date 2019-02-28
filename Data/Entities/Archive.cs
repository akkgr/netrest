using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Archive
    {
        public Archive()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int? CategoryId { get; set; }

        public int? SubCategoryId { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public string Remarks { get; set; }

        public int? RankId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int UserId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ArchiveCategory CategoryArchiveCategory { get; set; }

        public virtual ArchiveSubCategory SubCategoryArchiveSubCategory { get; set; }

        public virtual DocRank RankDocRank { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
