using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ClientHistoryServiceReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int ClientHistoryId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public decimal Balance { get; set; }

        public int? Active { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime LastUpdated { get; set; }

        #endregion

    }
}
