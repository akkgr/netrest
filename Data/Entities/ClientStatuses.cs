using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class ClientStatuses
    {
        public ClientStatuses()
        {
            #region Generated Constructor
            ActiveClients = new HashSet<Client>();
            ActiveClientHistories = new HashSet<ClientHistory>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public string Color { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Client> ActiveClients { get; set; }

        public virtual ICollection<ClientHistory> ActiveClientHistories { get; set; }

        #endregion

    }
}
