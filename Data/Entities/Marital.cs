using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Marital
    {
        public Marital()
        {
            #region Generated Constructor
            StatusClients = new HashSet<Client>();
            StatusClientHistories = new HashSet<ClientHistory>();
            StatusEmployees = new HashSet<Employee>();
            StatusIntakes = new HashSet<Intake>();
            StatusIntakePlans = new HashSet<IntakePlan>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Client> StatusClients { get; set; }

        public virtual ICollection<ClientHistory> StatusClientHistories { get; set; }

        public virtual ICollection<Employee> StatusEmployees { get; set; }

        public virtual ICollection<Intake> StatusIntakes { get; set; }

        public virtual ICollection<IntakePlan> StatusIntakePlans { get; set; }

        #endregion

    }
}
