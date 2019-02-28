using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class BoardMinuteCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public DateTime MeetingDate { get; set; }

        public string Minutes { get; set; }

        public int OrgTreeNodeId { get; set; }

        public DateTime? Emailed { get; set; }

        #endregion

    }
}
