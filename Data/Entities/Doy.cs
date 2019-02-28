using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Doy
    {
        public Doy()
        {
            #region Generated Constructor
            Companies = new HashSet<Company>();
            Traders = new HashSet<Trader>();
            Employees = new HashSet<Employee>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Company> Companies { get; set; }

        public virtual ICollection<Trader> Traders { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        #endregion

    }
}
