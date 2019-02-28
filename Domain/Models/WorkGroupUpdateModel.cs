using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class WorkGroupUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int? WorkGroupTypeId { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public string Remarks { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public int UserId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
