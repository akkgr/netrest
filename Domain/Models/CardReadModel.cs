using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class CardReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int CardTypeId { get; set; }

        public DateTime? DateIn { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CardValues { get; set; }

        public bool VisibleToEmployee { get; set; }

        public int UserId { get; set; }

        public int RankId { get; set; }

        public Byte[] Photo { get; set; }

        #endregion

    }
}
