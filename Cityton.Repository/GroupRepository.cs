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

    public interface IGroupRepository : IRepository<Group>
    {
        Task<Group> GetByName(string name);
        Task<List<Group>> Search(string toSearch);
        Task<List<Group>> GetMinorGroups(int minimalGroupSize);
    }

    public class GroupRepository : Repository<Group>, IGroupRepository
    {

        public GroupRepository(ApplicationContext context) : base(context) { }

        override public async Task<List<Group>> GetAll()
        {
            return await context.Groups
                .Include(g => g.Members)
                    .ThenInclude(pg => pg.User)
                .ToListAsync();
        }

        override public async Task<Group> Get(int id)
        {
            return await context.Groups
                .Where(g => g.Id == id)
                .Include(g => g.Members)
                    .ThenInclude(pg => pg.User)
                .FirstOrDefaultAsync();
        }

        public async Task<Group> GetByName(string name)
        {
            return await context.Groups.Where(g => g.Name == name).FirstOrDefaultAsync();
        }

        public async Task<List<Group>> Search(string toSearch)
        {
            StringComparison comparison = StringComparison.OrdinalIgnoreCase;

            return await context.Groups
            .Where(g =>
                g.Name.Contains(toSearch, comparison) ||
                g.Members.Where(pg => pg.Status == Status.Accepted).Select(pg => pg.User).Any(u => u.Username.Contains(toSearch, comparison))
            )
            .Include(g => g.Members)
                .ThenInclude(pg => pg.User)
            .ToListAsync();
        }

        public async Task<List<Group>> GetMinorGroups(int minimalGroupSize)
        {
            return await context.Groups
                .Where(g => g.Members.Count(pg => pg.Status == Status.Accepted) < minimalGroupSize)
                .Include(g => g.Members)
                    .ThenInclude(pg => pg.User)
                .ToListAsync();
        }
    }
}