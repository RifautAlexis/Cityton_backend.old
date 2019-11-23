using Cityton.Data.Models;
using Cityton.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Service
{

    public interface IUserService
    {
        void Update(User user);
        Task<User> Get(int id);
        Task<User> GetByUsername(string username);
        Task<User> GetByEmail(string email);
        Task<User> GetByPhoneNumber(string phoneNumber);
    }

    public class UserService : IUserService
    {

        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Update(User user)
        {
            userRepository.Update(user);
        }

        public async Task<User> Get(int id)
        {
            return await userRepository.Get(id);
        }

        public async Task<User> GetByUsername(string username)
        {
            return await userRepository.GetByUsername(username);
        }

        public async Task<User> GetByEmail(string email)
        {
            return await userRepository.GetByEmail(email);
        }

        public async Task<User> GetByPhoneNumber(string phoneNumber)
        {
            return await userRepository.GetByPhoneNumber(phoneNumber);
        }

    }
}