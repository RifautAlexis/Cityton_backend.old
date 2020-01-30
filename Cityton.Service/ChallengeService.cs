using Cityton.Data.Models;
using Cityton.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Service
{

    public interface IChallengeService
    {
        Task<IEnumerable<Challenge>> GetAll();
    }

    public class ChallengeService : IChallengeService
    {
        private IChallengeRepository challengeRepository;

        public ChallengeService(IChallengeRepository challengeRepository)
        {
            this.challengeRepository = challengeRepository;
        }

        public async Task<IEnumerable<Challenge>> GetAll()
        {
            return await challengeRepository.GetAll();
        }

    }

}