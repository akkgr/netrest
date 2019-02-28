using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class InfoMessageReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public string Caption { get; set; }

        public string Message { get; set; }

        public DateTime Commencement { get; set; }

        public DateTime Expiration { get; set; }

        public int UserId { get; set; }

        public string LinkTable { get; set; }

        public int? LinkId { get; set; }

        #endregion

    }
}
