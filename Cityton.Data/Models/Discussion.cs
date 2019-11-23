using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class Discussion : BaseEntities
    {

        public DateTime CreatedAt { get; set; }

        /*****/

        public ICollection<UserInDiscussion> UsersInDiscussion { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}