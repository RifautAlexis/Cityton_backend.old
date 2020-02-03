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
        Task<Challenge> Get(int challengeId);
        Task<IEnumerable<Challenge>> GetAllAccepted_Author_Achivements();
        Task<IEnumerable<Challenge>> GetAllWaiting_Author();
        Task<bool> ExistName(string name);
        Task<int> Create(ChallengeCreate challengeCreate, User connectedUser);
        Task<List<Challenge>> Search(string toSearch);
        Task Edit(ChallengeEdit challengeToEdit);
        Task Update(Challenge challengeToUpdate);
        Task Delete(Challenge challenge);
    }

    public class ChallengeService : IChallengeService
    {
        private IChallengeRepository challengeRepository;

        public ChallengeService(IChallengeRepository challengeRepository)
        {
            this.challengeRepository = challengeRepository;
        }

        public async Task<Challenge> Get(int challengeId)
        {
            return await challengeRepository.Get(challengeId);
        }

        public async Task<IEnumerable<Challenge>> GetAllAccepted_Author_Achivements()
        {
            return await challengeRepository.GetAllAccepted_Author_Achivements();
        }

        public async Task<IEnumerable<Challenge>> GetAllWaiting_Author()
        {
            return await challengeRepository.GetAllWaiting_Author();
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

        public async Task<List<Challenge>> Search(string toSearch)
        {
            return await this.challengeRepository.Search(toSearch);
        }

        public async Task Edit(ChallengeEdit challengeToEdit)
        {
            Challenge originalChallenge = await this.challengeRepository.Get(challengeToEdit.Id);

            originalChallenge.Name = challengeToEdit.Name;
            originalChallenge.Statement = challengeToEdit.Statement;

            await this.challengeRepository.Update(originalChallenge);
        }

        public async Task Update(Challenge challengeToUpdate)
        {
            await this.challengeRepository.Update(challengeToUpdate);
        }

        public async Task Delete(Challenge challenge)
        {
            await this.challengeRepository.Delete(challenge);
        }

    }

}