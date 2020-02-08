using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface IChatRepository : IRepository<Message>
    {
    }

    public class ChatRepository : Repository<Message>, IChatRepository
    {

        public ChatRepository(ApplicationContext context) : base(context) {  }

    }
}
