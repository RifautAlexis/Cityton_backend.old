using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class Achievement : BaseEntities
    {
        public DateTime UnlockedAt { get; set; }

        /*****/

        public virtual User Winner { get; set; }
        public virtual Challenge FromChallenge { get; set; }

        /*****/

        public int? WinnerId { get; set; }
        public int FromChallengeId { get; set; }
    }
}