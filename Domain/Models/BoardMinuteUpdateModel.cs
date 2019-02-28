using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class BoardMinuteUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public DateTime MeetingDate { get; set; }

        public string Minutes { get; set; }

        public int OrgTreeNodeId { get; set; }

        public DateTime? Emailed { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
