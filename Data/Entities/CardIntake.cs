using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class CardIntake
    {
        public CardIntake()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CardId { get; set; }

        public int IntakeId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Card Card { get; set; }

        public virtual Intake Intake { get; set; }

        #endregion

    }
}
