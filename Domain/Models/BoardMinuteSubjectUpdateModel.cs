using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class BoardMinuteSubjectUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int BoardminuteId { get; set; }

        public string Sn { get; set; }

        public string Subject { get; set; }

        public string Decision { get; set; }

        #endregion

    }
}
