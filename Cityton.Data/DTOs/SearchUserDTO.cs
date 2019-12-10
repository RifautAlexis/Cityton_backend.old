using Cityton.Data.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class SearchUserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Picture { get; set; }
        public Role Role { get; set; } = Role.Member;
    }
}
