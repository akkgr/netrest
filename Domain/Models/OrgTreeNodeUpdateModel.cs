using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class OrgTreeNodeUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int NodeId { get; set; }

        public string Code { get; set; }

        public bool IsActive { get; set; }

        public int? ViewOrder { get; set; }

        public string AppObject { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
