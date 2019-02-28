using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class ReceiptUpdateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public bool Payment { get; set; }

        public int Code { get; set; }

        public int RankId { get; set; }

        public string Publisher { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Trader { get; set; }

        public string TaxRecocrd { get; set; }

        public decimal Cash { get; set; }

        public decimal Other { get; set; }

        public bool BankTransfer { get; set; }

        public bool BankCheck { get; set; }

        public string BankRemarks { get; set; }

        public string Remarks { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
