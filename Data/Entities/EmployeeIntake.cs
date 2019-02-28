using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class EmployeeIntake
    {
        public EmployeeIntake()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int IntakeId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Employee Employee { get; set; }

        public virtual Intake Intake { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        #endregion

    }
}
