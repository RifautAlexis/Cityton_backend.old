using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class GroupDetailsDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ParticipantGroupDTO> Members { get; set; }
        public List<MembershipRequestDTO> MembershipRequests { get; set; }

    }
}