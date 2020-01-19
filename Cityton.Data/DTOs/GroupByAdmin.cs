using System;
using System.Collections.Generic;

namespace Cityton.Data.DTOs
{
    public class GroupByAdmin
    {

        public string Name { get; set; }
        public int CreatorId { get; set; }
        public List<int> MembersId { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}