using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class FlowChartStepReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int FlowChartId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
