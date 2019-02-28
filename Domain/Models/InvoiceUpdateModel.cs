using System;
using System.Collections.Generic;

namespace Sca.Domain.Models
{
    public partial class InvoiceUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        public int OrgTreeNodeId { get; set; }

        public int CompanyNodeId { get; set; }

        public int CompanyId { get; set; }

        public string CompanyTitle { get; set; }

        public string CompanyAFM { get; set; }

        public int TransactionTypeId { get; set; }

        public string TransactionTitle { get; set; }

        public int InvoiceTypeId { get; set; }

        public string InvoiceTitle { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        public DateTime Registered { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal RetentionSum { get; set; }

        public decimal TransferAmount { get; set; }

        public int ActivityCodeId { get; set; }

        public string Code { get; set; }

        public int CashAction { get; set; }

        public int TraderAction { get; set; }

        public bool ForTrader { get; set; }

        public bool CreditAndDebit { get; set; }

        public bool IsCash { get; set; }

        public bool NotInReport { get; set; }

        public bool NotInBudget { get; set; }

        public int DocRankId { get; set; }

        public int UserId { get; set; }

        public string ChequeNumber { get; set; }

        public DateTime? ChequeDate { get; set; }

        public string Remarks { get; set; }

        public string Notes { get; set; }

        public int? VirtualNodeId { get; set; }

        public bool? Eep { get; set; }

        public int? InvoiceId { get; set; }

        #endregion

    }
}
