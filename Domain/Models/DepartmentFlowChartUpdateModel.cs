using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DepartmentFlowChartUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public int FlowChartId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
