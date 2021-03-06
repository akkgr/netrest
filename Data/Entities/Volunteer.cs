using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Volunteer
    {
        public Volunteer()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Frequency { get; set; }

        public string FrequencyOther { get; set; }

        public bool? Ornings { get; set; }

        public bool? Venings { get; set; }

        public bool? WeekEnds { get; set; }

        public bool? WasMember { get; set; }

        public string Period { get; set; }

        public string Objective { get; set; }

        public string Description { get; set; }

        public string Training { get; set; }

        public string TrainingOther { get; set; }

        public string AreasOfInterest { get; set; }

        public string AreasOfInterestOther { get; set; }

        public string Health { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Intake Intake { get; set; }

        #endregion

    }
}
