using Cityton.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class Thread
    {
        public int DiscussionId { get; set; }
        public IEnumerable<UserMinimal> Participants { get; set; }
    }
}
