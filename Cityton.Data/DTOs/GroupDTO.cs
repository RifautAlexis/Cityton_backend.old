using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class GroupDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public List<ParticipantGroupDTO> Members { get; set; }

    }
}