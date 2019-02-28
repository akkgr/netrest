using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Eko
    {
        public Eko()
        {
            #region Generated Constructor
            Clients = new HashSet<Client>();
            ClientHistories = new HashSet<ClientHistory>();
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

        #endregion

    }
}
