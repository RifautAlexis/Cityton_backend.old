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

    public interface IDiscussionRepository : IRepository<Discussion>
    {
        Task<IEnumerable<Discussion>> GetThreads(int userId);
        Task<Discussion> GetDiscussionsWithGroup(int id);
    }

    public class DiscussionRepository : Repository<Discussion>, IDiscussionRepository
    {

        public DiscussionRepository(ApplicationContext context) : base(context) { }

        public async Task<IEnumerable<Discussion>> GetThreads(int userId)
        {
            return await context.Discussions
                .Where(d => d.UsersInDiscussion.Any(uid => uid.ParticipantId == userId))
                .Include(d => d.UsersInDiscussion)
                    .ThenInclude(uid => uid.Participant)
                .ToListAsync();
        }

        public async Task<Discussion> GetDiscussionsWithGroup(int id)
        {
            return await context.Discussions
                .Where(d => d.Id == id)
                .Include(d => d.Group)
                .FirstOrDefaultAsync();
        }

    }
}