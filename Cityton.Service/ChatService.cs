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
        Task<IEnumerable<Message>> GetMessagesByDiscussion(int discussionId);
        Task<Message> NewMessage(string message, int connectedUSerId, int discussionId);
    }

    public class ChatService : IChatService
    {
        private IMesageRepository messageRepository;
        private IUserRepository userRepository;

        public ChatService(IMesageRepository messageRepository, IUserRepository userRepository)
        {
            this.messageRepository = messageRepository;
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<Message>> GetMessagesByDiscussion(int discussionId)
        {
            return await this.messageRepository.GetMessagesByDiscussion(discussionId);
        }

        public async Task<Message> NewMessage(string message, int connectedUserId, int discussionId)
        {
            Message messageToAdd = new Message {
                Content = message,
                CreatedAt = DateTime.Now,
                AuthorId = connectedUserId,
                DiscussionId = discussionId,
                MediaId = null
            };

            await this.messageRepository.Insert(messageToAdd);

            messageToAdd.Author = await this.userRepository.Get(connectedUserId);

            return messageToAdd;
        }

    }

}