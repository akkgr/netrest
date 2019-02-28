using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Item
    {
        public Item()
        {
            #region Generated Constructor
            TreatmentMedecines = new HashSet<TreatmentMedecine>();
            ItemGroups = new HashSet<ItemGroup>();
            ItemTransactions = new HashSet<ItemTransaction>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int PackagingId { get; set; }

        public int CategoryId { get; set; }

        public int UnitId { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public string Remarks { get; set; }

        public string BarCode { get; set; }

        public int? OrgTreeNodeId { get; set; }

        public string Company { get; set; }

        public string ActiveSubstance { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<TreatmentMedecine> TreatmentMedecines { get; set; }

        public virtual Category Category { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual Packaging Packaging { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual ICollection<ItemGroup> ItemGroups { get; set; }

        public virtual ICollection<ItemTransaction> ItemTransactions { get; set; }

        #endregion

    }
}
