using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DivisionJob
    {
        public DivisionJob()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int DivisionId { get; set; }

        public DateTime ChangeDate { get; set; }

        public string Job { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Division Division { get; set; }

        #endregion

    }
}
