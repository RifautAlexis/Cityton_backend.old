using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Common;

namespace Cityton.Data.Models
{
    class ChallengeGiven : BaseEntities
    {

        public StatusChallenge Status { get; set; }

        /*****/

        public virtual Challenge Challenges { get; set; }
        public virtual Group ChallengedGroups { get; set; }
    }
}

