using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cityton.Domain.User
{
    class User : BaseEntities
    {

        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public string Role { get; set; }

        public Company Company { get; set; }

    }
}
