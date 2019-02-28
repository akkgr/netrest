using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DepartmentFlowChart
    {
        public DepartmentFlowChart()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public int FlowChartId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Department Department { get; set; }

        public virtual FlowChart FlowChart { get; set; }

        #endregion

    }
}
