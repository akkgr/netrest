using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class TraderUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public string BarCode { get; set; }

        public string ContractNo { get; set; }

        public DateTime? ContractStart { get; set; }

        public DateTime? ContractEnd { get; set; }

        public string Afm { get; set; }

        public int? DOYId { get; set; }

        public string Description { get; set; }

        public string Amount { get; set; }

        public string Remarks { get; set; }

        public bool? Recieve { get; set; }

        public bool? Provide { get; set; }

        public Byte[] Photo { get; set; }

        public int? RankId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int UserId { get; set; }

        #endregion

    }
}
