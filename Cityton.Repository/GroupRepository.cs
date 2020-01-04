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
    }
}