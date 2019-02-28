using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class TransactionTypeUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int Act { get; set; }

        public bool IsCash { get; set; }

        public int CustomerAct { get; set; }

        public int ProviderAct { get; set; }

        #endregion

    }
}
