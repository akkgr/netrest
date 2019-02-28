using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DocDocGroup
    {
        public DocDocGroup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int DocId { get; set; }

        public int GroupId { get; set; }

        public int Priority { get; set; }

        #endregion

        #region Generated Relationships
        public virtual DocGroup GroupDocGroup { get; set; }

        public virtual Document DocDocument { get; set; }

        #endregion

    }
}
