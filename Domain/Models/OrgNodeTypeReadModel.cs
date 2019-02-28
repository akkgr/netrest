using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class OrgNodeTypeReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public int TreeLevel { get; set; }

        public bool UserAvailable { get; set; }

        #endregion

    }
}
