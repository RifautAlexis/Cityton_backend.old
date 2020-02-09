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
        Task<int> NewMessage(string message, int connectedUSerId, int discussionId);
        Task<Message> GetMessage(int messageAddedId);
    }

    public class ChatService : IChatService
    {
        private IMesageRepository messageRepository;

        public ChatService(IMesageRepository messageRepository)
        {
            this.messageRepository = messageRepository;
        }

        public async Task<IEnumerable<Message>> GetMessagesByDiscussion(int discussionId)
        {
            return await this.messageRepository.GetMessagesByDiscussion(discussionId);
        }

        public async Task<int> NewMessage(string message, int connectedUSerId, int discussionId)
        {
            Message messageToAdd = new Message {
                Content = message,
                CreatedAt = DateTime.Now,
                AuthorId = connectedUSerId,
                DiscussionId = discussionId,
                MediaId = null
            };

            await this.messageRepository.Insert(messageToAdd);

            return messageToAdd.Id;
        }

        public async Task<Message> GetMessage(int messageAddedId)
        {
            return await this.messageRepository.Get_User(messageAddedId);
        }

    }

}