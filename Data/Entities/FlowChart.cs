using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class FlowChart
    {
        public FlowChart()
        {
            #region Generated Constructor
            FlowChartSteps = new HashSet<FlowChartStep>();
            DepartmentFlowCharts = new HashSet<DepartmentFlowChart>();
            #endregion
        }

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

        #region Generated Relationships
        public virtual ICollection<FlowChartStep> FlowChartSteps { get; set; }

        public virtual ICollection<DepartmentFlowChart> DepartmentFlowCharts { get; set; }

        #endregion

    }
}
