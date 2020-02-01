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

    public interface IChallengeService
    {
        Task<IEnumerable<Challenge>> GetAllAccepted_Author_Achivements();
        Task<bool> ExistName(string name);
        Task<int> Create(ChallengeCreate challengeCreate, User connectedUser);
    }

    public class ChallengeService : IChallengeService
    {
        private IChallengeRepository challengeRepository;

        public ChallengeService(IChallengeRepository challengeRepository)
        {
            this.challengeRepository = challengeRepository;
        }

        public async Task<IEnumerable<Challenge>> GetAllAccepted_Author_Achivements()
        {
            return await challengeRepository.GetAllAccepted_Author_Achivements();
        }

        public async Task<bool> ExistName(string name)
        {
            return await this.challengeRepository.GetByName(name) != null;
        }

        public async Task<int> Create(ChallengeCreate challengeCreate, User connectedUser)
        {
            Challenge newChallenge = new Challenge
            {
                Statement = challengeCreate.Statement,
                Name = challengeCreate.Name,
                Status = connectedUser.Role == Role.Admin ? Status.Accepted : Status.Waiting,
                CreatedAt = DateTime.Now,
                AuthorId = connectedUser.Id
            };

            await this.challengeRepository.Insert(newChallenge);

            Challenge challenge = await this.challengeRepository.GetByName(newChallenge.Name);

            return challenge.Id;
        }

    }

}