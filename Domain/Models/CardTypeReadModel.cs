using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class CardTypeReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public string Title { get; set; }

        public string Fields { get; set; }

        public string Description { get; set; }

        public int PersonType { get; set; }

        public bool Monthly { get; set; }

        #endregion

    }
}
