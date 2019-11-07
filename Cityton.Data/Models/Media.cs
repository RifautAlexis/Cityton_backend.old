using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class Media
    {

        public string Name { get; set; }
        public string Location { get; set; }
        public string Extension { get; set; }
        public string CreatedAt { get; set; }

        /*****/

        public virtual Message ContainedIn { get; set; }


    }
}
