using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class CardType
    {
        public CardType()
        {
            #region Generated Constructor
            Cards = new HashSet<Card>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Fields { get; set; }

        public string Description { get; set; }

        public int PersonType { get; set; }

        public bool Monthly { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Card> Cards { get; set; }

        #endregion

    }
}
