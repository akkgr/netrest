using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class NodeToNodeCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int ParentNode { get; set; }

        public int ChildNode { get; set; }

        public int UserId { get; set; }

        #endregion

    }
}
