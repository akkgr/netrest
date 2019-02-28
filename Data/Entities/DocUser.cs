using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DocUser
    {
        public DocUser()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int DocId { get; set; }

        public int UserId { get; set; }

        public int ActionInfo { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Document DocDocument { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
