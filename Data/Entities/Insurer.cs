using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Insurer
    {
        public Insurer()
        {
            #region Generated Constructor
            Clients = new HashSet<Client>();
            ClientHistories = new HashSet<ClientHistory>();
            MedicalExpenses = new HashSet<MedicalExpense>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<ClientHistory> ClientHistories { get; set; }

        public virtual ICollection<MedicalExpense> MedicalExpenses { get; set; }

        #endregion

    }
}
