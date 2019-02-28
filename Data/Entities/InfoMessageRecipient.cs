using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class InfoMessageRecipient
    {
        public InfoMessageRecipient()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int InfoMessageId { get; set; }

        public int UserId { get; set; }

        public bool Received { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual InfoMessage InfoMessage { get; set; }

        public virtual User User { get; set; }

        #endregion

    }
}
