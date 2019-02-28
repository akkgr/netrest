using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Treatment
    {
        public Treatment()
        {
            #region Generated Constructor
            TreatmentMedecines = new HashSet<TreatmentMedecine>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int Sn { get; set; }

        public int? IntakeId { get; set; }

        public int? ClientId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Njectable { get; set; }

        public string NjectableNote { get; set; }

        public string Nxiety { get; set; }

        public string NxietyNote { get; set; }

        public string NtenseΑnxiety { get; set; }

        public string NtenseΑnxietyNote { get; set; }

        public string Remarks { get; set; }

        public int UserId { get; set; }

        public int OrgTreeNodeId { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Client Client { get; set; }

        public virtual Intake Intake { get; set; }

        public virtual OrgTreeNode OrgTreeNode { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<TreatmentMedecine> TreatmentMedecines { get; set; }

        #endregion

    }
}
