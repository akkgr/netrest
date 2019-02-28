using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Parameter
    {
        public Parameter()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal? Value { get; set; }

        public int? ValueTypeId { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
