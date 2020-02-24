using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;
using Cityton.Data.Common;

namespace Cityton.Data.DTOs
{
    public class ChallengeChat
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Statement { get; set; }
        public string Author { get; set; }
        public Status Status { get; set; }

    }
}