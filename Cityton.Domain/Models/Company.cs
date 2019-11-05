using System;
using System.Collections.Generic;

namespace Cityton.Data.Models
{
    class Company: BaseEntities
    {

        public int MinGroupSize { get; set; }
        public int MaxGroupSize { get; set; }
        public DateTime CreatedAt { get; set; }

        /*****/

        public virtual ICollection<User> Users { get; set; }

    }
}
