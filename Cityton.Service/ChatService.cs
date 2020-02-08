using Cityton.Data.Models;
using Cityton.Data.DTOs;
using Cityton.Data.Common;
using Cityton.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Service
{

    public interface IChatService
    {
    }

    public class ChatService : IChatService
    {
        private IChatRepository chatRepository;

        public ChatService(IChatRepository chatRepository)
        {
            this.chatRepository = chatRepository;
        }

    }

}