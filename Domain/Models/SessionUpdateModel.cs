using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class SessionUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public DateTime DateIn { get; set; }

        public int ClientId { get; set; }

        public bool? Ppointment { get; set; }

        public string Comment { get; set; }

        public string Subject { get; set; }

        public string Estimation { get; set; }

        public string Valuation { get; set; }

        public string Bjectives { get; set; }

        public int? Members { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        #endregion

    }
}
