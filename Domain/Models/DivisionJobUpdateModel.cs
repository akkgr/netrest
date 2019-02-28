using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class DivisionJobUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int DivisionId { get; set; }

        public DateTime ChangeDate { get; set; }

        public string Job { get; set; }

        #endregion

    }
}
