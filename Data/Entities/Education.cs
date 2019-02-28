using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Education
    {
        public Education()
        {
            #region Generated Constructor
            Clients = new HashSet<Client>();
            ClientHistories = new HashSet<ClientHistory>();
            Employees = new HashSet<Employee>();
            Intakes = new HashSet<Intake>();
            IntakePlans = new HashSet<IntakePlan>();
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

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Intake> Intakes { get; set; }

        public virtual ICollection<IntakePlan> IntakePlans { get; set; }

        #endregion

    }
}
