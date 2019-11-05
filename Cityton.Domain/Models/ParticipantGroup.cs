using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Common;

namespace Cityton.Data.Models
{
    class ParticipantGroup : BaseEntities
    {

        public Boolean IsCreator { get; set; }
        public Status Status { get; set; } = Status.Waiting;

        /*****/

        public Group BelongingGroup { get; set; }
        public User User { get; set; }

    }
}
