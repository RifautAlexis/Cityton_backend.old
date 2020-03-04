using Cityton.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Data.Models
{
    public class Media : BaseEntities
    {

        // public string Name { get; set; }
        public string Location { get; set; }
        // public AllowedExtension Extension { get; set; }
        public DateTime CreatedAt { get; set; }

        /*****/

        public virtual Message ContainedIn { get; set; }

        /*****/

        public int MessageId { get; set; }
        // public int ContainedInId { get; set; }


    }
}