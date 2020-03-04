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
        Task<IEnumerable<Message>> GetByDiscussionIdWithAuthor_Media(int discussionId);
        Task<Message> GetMessageById(int messageId);
        Task<Message> GetMessageWithAuthor(int messageRemovedId);
    }

    public class MesageRepository : Repository<Message>, IMesageRepository
    {

        public MesageRepository(ApplicationContext context) : base(context) { }

        public async Task<IEnumerable<Message>> GetByDiscussionIdWithAuthor_Media(int discussionId)
        {
            return await this.context.Messages
                .Where(message => message.DiscussionId == discussionId)
                .OrderBy(message => message.CreatedAt)
                .Include(message => message.Author)
                .Include(message => message.Media)
                .ToListAsync();
        }

        public async Task<Message> GetMessageById(int messageId)
        {
            return await this.context.Messages
                .Where(message => message.Id == messageId)
                .Include(message => message.Author)
                .Include(message => message.Media)
                .FirstOrDefaultAsync();
        }

        public async Task<Message> GetMessageWithAuthor(int messageRemovedId)
        {
            return await this.context.Messages
                .Where(m => m.Id == messageRemovedId)
                .Include(m => m.Author)
                .Include(message => message.Media)
                .FirstOrDefaultAsync();
        }

    }
}
