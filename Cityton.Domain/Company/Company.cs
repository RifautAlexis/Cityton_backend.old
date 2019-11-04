using System;
using System.Collections.Generic;
using System.Text;

namespace Cityton.Domain.Company
{
    class Company: BaseEntities
    {

        public int MinGroupSize { get; set; }
        public int MaxGroupSize { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
