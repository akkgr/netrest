using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class CardClient
    {
        public CardClient()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CardId { get; set; }

        public int ClientId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Card Card { get; set; }

        public virtual Client Client { get; set; }

        #endregion

    }
}
