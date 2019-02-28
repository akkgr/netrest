using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class FlowChartCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? PreviousVersion { get; set; }

        #endregion

    }
}
