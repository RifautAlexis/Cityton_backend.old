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

        public static ChallengeDTO ToDTO(this Challenge data, User user, double nbTotalUsers)
        {
            if (data == null) return null;

            return new ChallengeDTO
            {
                Id = data.Id,
                Title = data.Name,
                Statement = data.Statement,
                Author = data.Author != null ? data.Author.Username : "Uknown",
                UnlockedAt = data.Achievements.Where(a => a.WinnerId == user.Id).Select(a => (DateTime?)a.UnlockedAt).FirstOrDefault(),
                SuccessRate = (data.Achievements.Count() / nbTotalUsers) * 100
            };
        }

        public static IEnumerable<ChallengeDTO> ToDTO(this IEnumerable<Challenge> data, User user, double nbTotalUsers)
        {
            return data.Select(ch => ch.ToDTO(user, nbTotalUsers)).ToList();
        }

    }
}