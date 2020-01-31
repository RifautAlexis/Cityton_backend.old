using Cityton.Data.Common;
using Cityton.Data.DTOs;
using Cityton.Data;
using Cityton.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cityton.Data.Mapper
{
    public static class ChallengeMapper
    {

        public static ChallengeDTO ToDTO(this Challenge data, User user)
        {
            if (data == null) return null;

            return new ChallengeDTO
            {
                Id = data.Id,
                Title = data.Name,
                Statement = data.Statement,
                Author = data.Author.Username,
                UnlockedAt = user.Achievements.Where(a => a.FromChallengeId == data.Id).Select(a => a.UnlockedAt).FirstOrDefault()
                // Author = data.Author.Username,
                // UnlockedAt = user.Achievements.Where(a => a.FromChallengeId == data.Id).Select(a => a.UnlockedAt).FirstOrDefault()
            };
        }

        public static IEnumerable<ChallengeDTO> ToDTO(this IEnumerable<Challenge> data, User user)
        {
            return data.Select(ch => ch.ToDTO(user)).ToList();
        }

    }
}