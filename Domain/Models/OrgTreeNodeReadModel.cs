using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class OrgTreeNodeReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int? ParentId { get; set; }

        public int NodeId { get; set; }

        public string Code { get; set; }

        public bool IsActive { get; set; }

        public int? ViewOrder { get; set; }

        public string AppObject { get; set; }

        #endregion

    }
}
