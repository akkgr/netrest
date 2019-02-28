using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DepartmentUser
    {
        public DepartmentUser()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int DepartmentId { get; set; }

        public int UserId { get; set; }

        public bool Manager { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Department Department { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
