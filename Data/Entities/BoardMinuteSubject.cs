using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class BoardMinuteSubject
    {
        public BoardMinuteSubject()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int BoardminuteId { get; set; }

        public string Sn { get; set; }

        public string Subject { get; set; }

        public string Decision { get; set; }

        #endregion

        #region Generated Relationships
        public virtual BoardMinute BoardMinute { get; set; }

        #endregion

    }
}
