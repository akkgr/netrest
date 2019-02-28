using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ItemGroupReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int ItemId { get; set; }

        public decimal Quantity { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public string GroupId { get; set; }

        public string GroupName { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
