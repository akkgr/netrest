using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class BoardMinuteSubjectReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int BoardminuteId { get; set; }

        public string Sn { get; set; }

        public string Subject { get; set; }

        public string Decision { get; set; }

        #endregion

    }
}
