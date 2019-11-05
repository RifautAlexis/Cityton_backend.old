using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    class Group : BaseEntities
    {

        public string Name { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedAt { get; set; }

        /*****/

        public virtual ICollection<ParticipantGroup> Members { get; set; }
        public virtual ICollection<ChallengeGiven> ChallengeGivens { get; set; }

    }
}
