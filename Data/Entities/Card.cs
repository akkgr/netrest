using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Card
    {
        public Card()
        {
            #region Generated Constructor
            CardClients = new HashSet<CardClient>();
            CardEmployees = new HashSet<CardEmployee>();
            CardIntakes = new HashSet<CardIntake>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int CardTypeId { get; set; }

        public DateTime? DateIn { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CardValues { get; set; }

        public bool VisibleToEmployee { get; set; }

        public int UserId { get; set; }

        public int RankId { get; set; }

        public Byte[] Photo { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual CardType CardType { get; set; }

        public virtual DocRank RankDocRank { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<CardClient> CardClients { get; set; }

        public virtual ICollection<CardEmployee> CardEmployees { get; set; }

        public virtual ICollection<CardIntake> CardIntakes { get; set; }

        #endregion

    }
}
