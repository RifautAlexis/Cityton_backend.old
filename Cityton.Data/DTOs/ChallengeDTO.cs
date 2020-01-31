using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data.Models;

namespace Cityton.Data.DTOs
{
    public class ChallengeDTO
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Statement { get; set; }
        public string Author { get; set; }
        public DateTime? UnlockedAt { get; set; }

    }
}