using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Invoice
    {
        public Invoice()
        {
            #region Generated Constructor
            Invoices = new HashSet<Invoice>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

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

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ActivityCode ActivityCode { get; set; }

        public virtual Company Company { get; set; }

        public virtual DocRank DocRank { get; set; }

        public virtual Invoice InvoiceMember { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual OrgTreeNode CompanyNodeOrgTreeNode { get; set; }

        public virtual OrgTreeNode VirtualNodeOrgTreeNode { get; set; }

        public virtual TransactionType TransactionType { get; set; }

        public virtual User User { get; set; }

        public virtual MedicalExpense MedicalExpense { get; set; }

        #endregion

    }
}
