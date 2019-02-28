using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class InfoMessageUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Caption { get; set; }

        public string Message { get; set; }

        public DateTime Commencement { get; set; }

        public DateTime Expiration { get; set; }

        public int UserId { get; set; }

        public string LinkTable { get; set; }

        public int? LinkId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
