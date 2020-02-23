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
        Task<IEnumerable<Message>> GetByDiscussionIdWithAuthor(int discussionId);
        Task<Message> GetMessage(int messageId);
        Task<Message> NewMessage(string message, int connectedUSerId, int discussionId);
        Task<IEnumerable<Discussion>> GetThreads(int userId);
        Task<Discussion> GetDiscussion(int discussionId);
        Task<Message> RemoveMessage(int messageId);
        Task<Message> GetMessageWithAuthor(int messageRemovedId);
    }

    public class ChatService : IChatService
    {
        private IMesageRepository messageRepository;
        private IUserRepository userRepository;
        private IDiscussionRepository discussionRepository;

        public ChatService(IMesageRepository messageRepository, IUserRepository userRepository, IDiscussionRepository discussionRepository)
        {
            this.messageRepository = messageRepository;
            this.userRepository = userRepository;
            this.discussionRepository = discussionRepository;
        }

        public async Task<IEnumerable<Message>> GetByDiscussionIdWithAuthor(int discussionId)
        {
            return await this.messageRepository.GetByDiscussionIdWithAuthor(discussionId);
        }

        public async Task<Message> GetMessage(int messageId)
        {
            return await this.messageRepository.GetMessageById(messageId);
        }

        public async Task<Message> NewMessage(string message, int connectedUserId, int discussionId)
        {
            Message messageToAdd = new Message
            {
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

        public async Task<IEnumerable<Discussion>> GetThreads(int userId)
        {
            return await this.discussionRepository.GetThreads(userId);
        }

        public async Task<Discussion> GetDiscussion(int discussionId)
        {
            return await this.discussionRepository.Get(discussionId);
        }

        public async Task<Message> RemoveMessage(int messageId)
        {
            Message messageToRemove = await this.messageRepository.Get(messageId);

            messageToRemove.Content = null;

            await this.messageRepository.Update(messageToRemove);

            return messageToRemove;
        }

        public async Task<Message> GetMessageWithAuthor(int messageRemovedId)
        {
            return await this.messageRepository.GetMessageWithAuthor(messageRemovedId);
        }

    }

}