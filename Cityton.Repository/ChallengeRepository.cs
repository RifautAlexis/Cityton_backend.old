using Cityton.Data.Models;
using Cityton.Data.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface IChallengeRepository : IRepository<Challenge>
    {
        Task<IEnumerable<Challenge>> GetAllAccepted_Author_Achivements();
        Task<Challenge> GetByName(string name);
    }

    public class ChallengeRepository : Repository<Challenge>, IChallengeRepository
    {
        public ChallengeRepository(ApplicationContext context) : base(context) { }

        public async Task<IEnumerable<Challenge>> GetAllAccepted_Author_Achivements()
        {
            return await context.Challenges
                .Where(ch => ch.Status == Status.Accepted)
                .Include(ch => ch.Author)
                .Include(ch => ch.Achievements)
                .ToListAsync();
        }

        public async Task<Challenge> GetByName(string name)
        {
            return await context.Challenges.Where(ch => ch.Name == name).FirstOrDefaultAsync();
        }
    }

}
