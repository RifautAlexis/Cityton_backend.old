using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface IMesageRepository : IRepository<Message>
    {
        Task<IEnumerable<Message>> GetMessagesByDiscussion(int discussionId);
    }

    public class MesageRepository : Repository<Message>, IMesageRepository
    {

        public MesageRepository(ApplicationContext context) : base(context) { }

        public async Task<IEnumerable<Message>> GetMessagesByDiscussion(int discussionId)
        {
            return await this.context.Messages
            .Where(message => message.DiscussionId == discussionId)
            .OrderBy(message => message.CreatedAt)
            .Include(message => message.Author)
            .ToListAsync();
        }

    }
}
