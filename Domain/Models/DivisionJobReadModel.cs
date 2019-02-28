using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DivisionJobReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int DivisionId { get; set; }

        public DateTime ChangeDate { get; set; }

        public string Job { get; set; }

        #endregion

    }
}
