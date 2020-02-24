using Cityton.Data;
using Cityton.Data.Common;
using Cityton.Data.Models;
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
        Task<IEnumerable<Challenge>> GetChallengesByGroupId(int groupId);
    }

    public class ChallengeGivenRepository : Repository<ChallengeGiven>, IChallengeGivenRepository
    {

        public ChallengeGivenRepository(ApplicationContext context) : base(context) { }

        public async Task<IEnumerable<Challenge>> GetChallengesByGroupId(int groupId)
        {
            return await context.ChallengesGiven
                .Where(cg => cg.ChallengedGroupId == groupId)
                .Include(cg => cg.Challenge)
                .Select(cg => cg.Challenge)
                .ToListAsync();
        }

    }
}