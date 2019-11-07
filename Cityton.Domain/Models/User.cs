using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Cityton.Data.Common;

namespace Cityton.Data.Models
{
    class User : BaseEntities
    {

        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public Role Role { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


        /*****/

        public virtual Company Company { get; set; }
        public virtual ICollection<ParticipantGroup> ParticipantGroup { get; set; }
        public virtual ICollection<Challenge> Challenges { get; set; }
        public virtual ICollection<Achievement> Achievements { get; set; }
        public virtual ICollection<UserInDiscussion> UserInDiscussion { get; set; }
        public virtual ICollection<Message> MessagesWriten { get; set; }


    }
}
