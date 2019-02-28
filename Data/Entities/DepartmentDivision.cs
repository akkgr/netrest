using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DepartmentDivision
    {
        public DepartmentDivision()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int DepartmentId { get; set; }

        public int DivisionId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Department Department { get; set; }

        public virtual Division Division { get; set; }

        #endregion

    }
}
