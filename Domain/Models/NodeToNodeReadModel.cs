using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class NodeToNodeReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int ParentNode { get; set; }

        public int ChildNode { get; set; }

        public int UserId { get; set; }

        public bool Invoice { get; set; }

        #endregion

    }
}
