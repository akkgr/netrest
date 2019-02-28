using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class WorkGroupCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public int? WorkGroupTypeId { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public string Remarks { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int UserId { get; set; }

        #endregion

    }
}
