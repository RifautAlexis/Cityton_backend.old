using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class Group : BaseEntities
    {

        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        /*****/

        public virtual ICollection<ParticipantGroup> Members { get; set; }
        public virtual ICollection<ChallengeGiven> ChallengesGiven { get; set; }
        public virtual Discussion Discussion { get; set; }

        /*****/

        public int DiscussionId { get; set; }

    }
}