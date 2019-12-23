using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class Group : BaseEntities
    {

        public string Name { get; set; }
        public string Picture { get; set; } = "https://res.cloudinary.com/dakczk6el/image/upload/v1576003103/default.png";
        public DateTime CreatedAt { get; set; }

        /*****/

        public virtual ICollection<ParticipantGroup> Members { get; set; }
        public virtual ICollection<ChallengeGiven> ChallengesGiven { get; set; }

    }
}