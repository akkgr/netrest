using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class PublicationDivision
    {
        public PublicationDivision()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int PublicationId { get; set; }

        public int DivisionId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Division Division { get; set; }

        public virtual Publication Publication { get; set; }

        #endregion

    }
}
