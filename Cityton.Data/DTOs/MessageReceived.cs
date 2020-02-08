using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.DTOs
{
    public class MessageReceived : BaseEntities
    {

        public string Content { get; set; }

        /*****/

        public int AuthorId { get; set; }
        public int DiscussionId { get; set; }


    }
}