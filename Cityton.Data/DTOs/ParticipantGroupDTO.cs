using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class ParticipantGroupDTO
    {

        public int RequestId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public bool IsCreator { get; set; }

    }
}