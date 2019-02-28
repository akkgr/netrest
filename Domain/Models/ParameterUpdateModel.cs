using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ParameterUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public decimal? Value { get; set; }

        public int? ValueTypeId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        #endregion

    }
}
