using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Leave
    {
        public Leave()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public int BsenceTypeId { get; set; }

        public int Year { get; set; }

        public int? Total { get; set; }

        public int? Used { get; set; }

        public int? Remain { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual RequestType BsenceTypeRequestType { get; set; }

        public virtual User EmployeeUser { get; set; }

        #endregion

    }
}
