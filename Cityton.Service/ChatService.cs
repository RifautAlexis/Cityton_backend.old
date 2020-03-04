using Cityton.Data.Models;
using Cityton.Data.DTOs;
using Cityton.Data.Common;
using Cityton.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Cityton.Service
{

    public interface IChatService
    {
        Task<IEnumerable<Message>> GetByDiscussionIdWithAuthor_Media(int discussionId);
        Task<Message> GetMessage(int messageId);
        Task<Message> NewMessage(string message, int connectedUSerId, int discussionId, string imageUrl);
        Task<IEnumerable<Discussion>> GetThreads(int userId);
        Task<Discussion> GetThread(int threadId);
        Task<Discussion> GetDiscussion(int discussionId);
        Task<Message> RemoveMessage(int messageId);
        Task<Message> GetMessageWithAuthor(int messageRemovedId);
        Task<IEnumerable<ChallengeChat>> GetChallengesGivenFromGroup(int discussionId);
        Task<ChallengeGiven> GetChallengeGiven(int ChallengeGivenId);
        Task UpdateChallengeGiven(ChallengeGiven ChallengeGiven);
        Task UpdateDiscussion(Discussion discussion);
        Task<Discussion> GetDiscussionByName(string newName);
        Task AddInDiscussion(int userId, int threadId);
        Task RemoveFromDiscussion(int userId, int threadId);
    }

    public class ChatService : IChatService
    {
        private IMesageRepository messageRepository;
        private IUserRepository userRepository;
        private IDiscussionRepository discussionRepository;
        private IChallengeGivenRepository challengeGivenRepository;
        private IUserInDiscussionRepository userIniscussionRepository;
        private IMediaRepository mediaRepository;

        public ChatService(
            IMesageRepository messageRepository,
            IUserRepository userRepository,
            IDiscussionRepository discussionRepository,
            IUserInDiscussionRepository userIniscussionRepository,
            IChallengeGivenRepository challengeGivenRepository,
            IMediaRepository mediaRepository
            )
        {
            this.messageRepository = messageRepository;
            this.userRepository = userRepository;
            this.discussionRepository = discussionRepository;
            this.challengeGivenRepository = challengeGivenRepository;
            this.userIniscussionRepository = userIniscussionRepository;
            this.mediaRepository = mediaRepository;
        }

        public async Task<IEnumerable<Message>> GetByDiscussionIdWithAuthor_Media(int discussionId)
        {
            return await this.messageRepository.GetByDiscussionIdWithAuthor_Media(discussionId);
        }

        public async Task<Message> GetMessage(int messageId)
        {
            return await this.messageRepository.GetMessageById(messageId);
        }

        public async Task<Message> NewMessage(string message, int connectedUserId, int discussionId, string imageUrl)
        {
            Message messageToAdd = new Message
            {
                Content = string.IsNullOrWhiteSpace(imageUrl) ? null : message,
                CreatedAt = DateTime.Now,
                AuthorId = connectedUserId,
                DiscussionId = discussionId,
                MediaId = null
            };

            await this.messageRepository.Insert(messageToAdd);

            if (!string.IsNullOrWhiteSpace(imageUrl))
            {
                Media mediaToAdd = new Media {
                    Location = imageUrl,
                    CreatedAt = DateTime.Now,
                    MessageId = messageToAdd.Id
                };

                await this.mediaRepository.Insert(mediaToAdd);

                messageToAdd.MediaId = mediaToAdd.Id;

                await this.messageRepository.Update(messageToAdd);

                messageToAdd.Media = mediaToAdd;

            } else {
                messageToAdd.Media = null;
            }

            messageToAdd.Author = await this.userRepository.Get(connectedUserId);

            return messageToAdd;
        }

        public async Task<IEnumerable<Discussion>> GetThreads(int userId)
        {
            return await this.discussionRepository.GetThreads(userId);
        }

        public async Task<Discussion> GetThread(int threadId)
        {
            return await this.discussionRepository.GetThread(threadId);
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

        public async Task<IEnumerable<ChallengeChat>> GetChallengesGivenFromGroup(int discussionId)
        {
            Discussion discussion = await this.discussionRepository.GetDiscussionsWithGroup(discussionId);

            if (discussion.GroupId != null)
            {
                return await this.challengeGivenRepository.GetChallengeChatByGroupId(discussion.GroupId.Value);
            }

            return new List<ChallengeChat>();
        }

        public async Task<ChallengeGiven> GetChallengeGiven(int ChallengeGivenId)
        {
            return await this.challengeGivenRepository.Get(ChallengeGivenId);
        }

        public async Task UpdateChallengeGiven(ChallengeGiven ChallengeGiven)
        {
            await this.challengeGivenRepository.Update(ChallengeGiven);
            
        }

        public async Task UpdateDiscussion(Discussion discussion)
        {
            await this.discussionRepository.Update(discussion);
            
        }

        public async Task<Discussion> GetDiscussionByName(string newName)
        {
            return await this.discussionRepository.GetDiscussionByName(newName);
            
        }

        public async Task AddInDiscussion(int userId, int threadId)
        {
            UserInDiscussion userInDiscussion = new UserInDiscussion {
                JoinedAt = DateTime.Now,
                DiscussionId = threadId,
                ParticipantId = userId
            };

            await this.userIniscussionRepository.Insert(userInDiscussion);
        }

        public async Task RemoveFromDiscussion(int userId, int threadId)
        {
            Discussion discussion = await this.discussionRepository.GetDiscussionWithUID(threadId);

            UserInDiscussion userTodelete = discussion.UsersInDiscussion.Where(uid => uid.ParticipantId == userId).FirstOrDefault();

            await this.userIniscussionRepository.Delete(userTodelete);
        }
    }

}