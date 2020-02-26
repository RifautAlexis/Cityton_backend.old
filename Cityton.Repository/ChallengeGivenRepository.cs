using Cityton.Data;
using Cityton.Data.Common;
using Cityton.Data.Models;
using Cityton.Data.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface IChallengeGivenRepository : IRepository<ChallengeGiven>
    {
        Task<IEnumerable<ChallengeChat>> GetChallengeChatByGroupId(int groupId);
    }

    public class ChallengeGivenRepository : Repository<ChallengeGiven>, IChallengeGivenRepository
    {

        public ChallengeGivenRepository(ApplicationContext context) : base(context) { }

        public async Task<IEnumerable<ChallengeChat>> GetChallengeChatByGroupId(int groupId)
        {
            return await context.ChallengesGiven
                .Where(cg => cg.ChallengedGroupId == groupId)
                .Include(cg => cg.Challenge)
                .Select(cg => new ChallengeChat
                {
                    ChallengeGivenId = cg.Id,
                    Name = cg.Challenge.Name,
                    Statement = cg.Challenge.Statement,
                    Author = cg.Challenge.Author != null ? cg.Challenge.Author.Username : "Uknown",
                    Status = cg.Status
                }
                )
                .ToListAsync();
        }

    }
}