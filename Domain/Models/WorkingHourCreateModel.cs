using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class WorkingHourCreateModel
    {
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

    }
}
