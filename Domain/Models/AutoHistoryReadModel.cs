using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class AutoHistoryReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public string RowId { get; set; }

        public string TableName { get; set; }

        public string Changed { get; set; }

        public int Kind { get; set; }

        #endregion

    }
}
