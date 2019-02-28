using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class OrgNodeTypeCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int TreeLevel { get; set; }

        public bool UserAvailable { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
