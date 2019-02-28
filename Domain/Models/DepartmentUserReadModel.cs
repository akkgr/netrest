using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DepartmentUserReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int DepartmentId { get; set; }

        public int UserId { get; set; }

        public bool Manager { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        #endregion

    }
}
