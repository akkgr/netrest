using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ItemReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public int PackagingId { get; set; }

        public int CategoryId { get; set; }

        public int UnitId { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public string Remarks { get; set; }

        public string BarCode { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public string Company { get; set; }

        public string ActiveSubstance { get; set; }

        #endregion

    }
}
