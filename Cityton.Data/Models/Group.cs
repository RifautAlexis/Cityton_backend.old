using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class Group : BaseEntities
    {

        public string Name { get; set; }
        public string Picture { get; set; } = "Have to define a location to default picture !";
        public DateTime CreatedAt { get; set; }

        /*****/

        public virtual ICollection<ParticipantGroup> Members { get; set; }
        public virtual ICollection<ChallengeGiven> ChallengesGiven { get; set; }

    }
}
