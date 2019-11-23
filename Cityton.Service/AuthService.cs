using Cityton.Data.Models;
using Cityton.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Service
{

    public interface IAuthService
    {
        Task<User> Authenticate(string email, string password);
        Task<User> Register(User user, string password);
    }

    public class AuthService : IAuthService
    {

        private IUserRepository userRepository;
        private ICompanyRepository companyRepository;

        public AuthService(IUserRepository userRepository, ICompanyRepository companyRepository)
        {
            this.userRepository = userRepository;
            this.companyRepository = companyRepository;
        }

        public async Task<User> Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) { return null; }

            User user = await userRepository.GetByEmail(email);

            if (user == null) { return null; }

            if (!user.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)) { return null; }

            return user;

        }

        public async Task<User> Register(User user, string password)
        {

            user.CreatePasswordHash(password);

            //user.Company = await companyRepository.Get(user.CompanyId);
            await companyRepository.Get(user.CompanyId);

            await userRepository.Insert(user);

            Company company = await companyRepository.Get(1);

            user.Company = company;
            company.Users.Add(user);

            await companyRepository.Update(company);
            await userRepository.Update(user);

            return user;

        }

    }

}