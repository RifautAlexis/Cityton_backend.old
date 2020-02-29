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
        Task<Discussion> GetThread(int threadId);
        Task<Discussion> GetDiscussionsWithGroup(int id);
        Task<Discussion> GetDiscussionByName(string name);
        Task<Discussion> GetDiscussionWithUID(int threadId);
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
        
        public async Task<Discussion> GetThread(int threadId)
        {
            return await context.Discussions
                .Where(d => d.Id == threadId)
                .Include(d => d.UsersInDiscussion)
                    .ThenInclude(uid => uid.Participant)
                .FirstOrDefaultAsync();
        }

        public async Task<Discussion> GetDiscussionsWithGroup(int id)
        {
            return await context.Discussions
                .Where(d => d.Id == id)
                .Include(d => d.Group)
                .FirstOrDefaultAsync();
        }

        public async Task<Discussion> GetDiscussionByName(string name)
        {
            return await context.Discussions
                .Where(d => d.Name == name)
                .FirstOrDefaultAsync();
        }

        public async Task<Discussion> GetDiscussionWithUID(int threadId)
        {
            return await context.Discussions
                .Where(d => d.Id == threadId)
                .Include(d => d.UsersInDiscussion)
                .FirstOrDefaultAsync();
        }

    }
}