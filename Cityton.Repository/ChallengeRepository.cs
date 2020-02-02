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
        Task<IEnumerable<Challenge>> GetAllWaiting_Author();
        Task<Challenge> GetByName(string name);
        Task<List<Challenge>> Search(string toSearch);
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

        public async Task<IEnumerable<Challenge>> GetAllWaiting_Author()
        {
            return await context.Challenges
                .Where(ch => ch.Status == Status.Waiting)
                .Include(ch => ch.Author)
                .ToListAsync();
        }

        public async Task<Challenge> GetByName(string name)
        {
            return await context.Challenges.Where(ch => ch.Name == name).FirstOrDefaultAsync();
        }

        public async Task<List<Challenge>> Search(string toSearch)
        {
            StringComparison comparison = StringComparison.OrdinalIgnoreCase;

            return await context.Challenges
            .Where(g =>
                g.Name.Contains(toSearch, comparison) ||
                g.Statement.Contains(toSearch, comparison)
            )
            .ToListAsync();
        }
    }

}
