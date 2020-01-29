using System;
using System.Collections.Generic;

namespace Cityton.Data.DTOs
{
    public class GroupEdit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public List<int> MembersId { get; set; }
        
    }
}