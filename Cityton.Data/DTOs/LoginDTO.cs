using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class LoginDTO
    {

        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; } = "Have to define a location to default picture !";
        public string Password { get; set; }

    }
}
