using Cityton.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class UserInDiscussion : BaseEntities
    {

        public DateTime JoinedAt { get; set; }

        /*****/

        public virtual User Participant { get; set; }
        public virtual Discussion Discussion { get; set; }

        /*****/

        public int ParticipantId { get; set; }
        public int DiscussionId { get; set; }


    }
}
