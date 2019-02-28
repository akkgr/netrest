using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class FlowChartStepReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int FlowChartId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        #endregion

    }
}
