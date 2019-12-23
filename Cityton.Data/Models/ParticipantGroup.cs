using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Common;

namespace Cityton.Data.Models
{
    public class ParticipantGroup : BaseEntities
    {

        public Boolean IsCreator { get; set; }
        public Status Status { get; set; } = Status.Waiting;
        public DateTime CreatedAt { get; set; }

        /*****/

        public virtual Group BelongingGroup { get; set; }
        public virtual User User { get; set; }

        /*****/

        public int BelongingGroupId { get; set; }
        public int UserId { get; set; }

    }
}