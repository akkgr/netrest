using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DepartmentUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public DateTime OperationStart { get; set; }

        public DateTime? OperationEnd { get; set; }

        public int? RootId { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public string Procedures { get; set; }

        public DateTime? ChangeDate { get; set; }

        public int? PreviousVersion { get; set; }

        #endregion

    }
}
