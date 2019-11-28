using Cityton.Data;
using Cityton.Data.Common;
using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface IUserRepository : IRepository<User>
    {

        Task<User> GetByEmail(string email);
        Task<User> GetByUsername(string username);
        Task<User> GetByPhoneNumber(string phoneNumber);
        Task<List<User>> GetByUsernameRole(string username, string filterRole);

    }

    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(ApplicationContext context) : base(context) {  }

        public async Task<User> GetByEmail(string email)
        {
            return await context.Users.Where(u => u.Email == email).FirstOrDefaultAsync();
        }

        public async Task<User> GetByUsername(string username)
        {
            return await context.Users.Where(user => user.Username == username).FirstOrDefaultAsync();
        }

        public async Task<User> GetByPhoneNumber(string phoneNumber)
        {
            return await context.Users.Where(u => u.PhoneNumber == phoneNumber).FirstOrDefaultAsync();
        }

        public async Task<List<User>> GetByUsernameRole(string username, string filterRole)
        {
            if (!filterRole.Equals("All"))
            {
                Role role = filterRole.ToRole();
                Console.WriteLine(role);
                Console.WriteLine(username);
                return await context.Users.Where(u => (u.Username.Contains(username)) && (u.Role == role)).ToListAsync();
            }

            return await context.Users.Where(user => user.Username == username).ToListAsync();
        }

    }
}