using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class Message : BaseEntities
    {

        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        /*****/

        public virtual User Author { get; set; }
        public virtual Discussion Discussion { get; set; }
        public virtual Media Media { get; set; }


    }
}
