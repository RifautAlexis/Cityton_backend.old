using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Data.DTOs
{
    public class GroupDetailsDTO
    {

        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ParticipantGroupDTO> Members { get; set; }
        public List<MembershipRequestDTO> MembershipRequests { get; set; }
        public int CreatorId { get; set; }


    }
}