using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ArchiveUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public int? CategoryId { get; set; }

        public int? SubCategoryId { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public string Remarks { get; set; }

        public int? RankId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int UserId { get; set; }

        #endregion

    }
}
