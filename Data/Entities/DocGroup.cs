using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class DocGroup
    {
        public DocGroup()
        {
            #region Generated Constructor
            GroupDocDocGroups = new HashSet<DocDocGroup>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Remarks { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<DocDocGroup> GroupDocDocGroups { get; set; }

        #endregion

    }
}
