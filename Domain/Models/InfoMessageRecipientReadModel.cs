using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class InfoMessageRecipientReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int InfoMessageId { get; set; }

        public int UserId { get; set; }

        public bool Received { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}