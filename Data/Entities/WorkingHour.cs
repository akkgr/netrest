using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class WorkingHour
    {
        public WorkingHour()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int OrgTreeNodeId { get; set; }

        public int EmployeeId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int WeekDay { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Employee Employee { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        #endregion

    }
}
