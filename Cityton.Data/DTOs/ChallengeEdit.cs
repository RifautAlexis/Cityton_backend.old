using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Data.DTOs
{
    public class ChallengeEdit
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Statement { get; set; }

    }
}