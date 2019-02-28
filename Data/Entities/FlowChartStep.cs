using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class FlowChartStep
    {
        public FlowChartStep()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int FlowChartId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual FlowChart FlowChart { get; set; }

        #endregion

    }
}
