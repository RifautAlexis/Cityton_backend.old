using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class GroupInfosEdit
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public UserMinimal Creator { get; set; }
        public List<UserMinimal> Members { get; set; }

    }
}