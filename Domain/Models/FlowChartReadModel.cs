using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class FlowChartReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Byte[] RowVersion { get; set; }

        public int? PreviousVersion { get; set; }

        #endregion

    }
}
