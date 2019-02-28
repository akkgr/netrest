using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ContractType
    {
        public ContractType()
        {
            #region Generated Constructor
            Employees = new HashSet<Employee>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Employee> Employees { get; set; }

        #endregion

    }
}
