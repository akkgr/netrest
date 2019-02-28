using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class CardTypeUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Fields { get; set; }

        public string Description { get; set; }

        public int PersonType { get; set; }

        public bool Monthly { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
