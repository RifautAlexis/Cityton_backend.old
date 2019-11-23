using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class RegisterDTO
    {

        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }

    }
}