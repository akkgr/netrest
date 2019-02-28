using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class RequestType
    {
        public RequestType()
        {
            #region Generated Constructor
            Requests = new HashSet<Request>();
            BsenceTypeLeaves = new HashSet<Leave>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public int Category { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Request> Requests { get; set; }

        public virtual ICollection<Leave> BsenceTypeLeaves { get; set; }

        #endregion

    }
}
