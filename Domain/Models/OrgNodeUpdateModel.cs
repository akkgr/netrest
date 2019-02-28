using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class OrgNodeUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public string Code { get; set; }

        public int NodeTypeId { get; set; }

        public bool IsActive { get; set; }

        public int? ViewOrder { get; set; }

        public string AppObject { get; set; }

        #endregion

    }
}
