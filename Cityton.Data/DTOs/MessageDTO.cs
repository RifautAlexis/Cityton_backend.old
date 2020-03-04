using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class MessageDTO
    {

        public int Id { get; set; }
        public string Content { get; set; }
        public MediaMinimal Media { get; set; }
        public UserMinimal Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DiscussionId { get; set; }

    }

}