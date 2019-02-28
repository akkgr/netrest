using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class InfoMessageRecipientUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int InfoMessageId { get; set; }

        public int UserId { get; set; }

        public bool Received { get; set; }

        #endregion

    }
}
