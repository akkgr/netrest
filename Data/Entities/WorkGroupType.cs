using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class WorkGroupType
    {
        public WorkGroupType()
        {
            #region Generated Constructor
            WorkGroups = new HashSet<WorkGroup>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<WorkGroup> WorkGroups { get; set; }

        #endregion

    }
}
