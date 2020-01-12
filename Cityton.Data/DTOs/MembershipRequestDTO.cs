using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Common;

namespace Cityton.Data.DTOs
{
    public class MembershipRequestDTO
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}