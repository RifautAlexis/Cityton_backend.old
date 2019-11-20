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

    }

    public class UserRepository : Repository<User>, IUserRepository
    {

        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _context.Users.Where(u => u.Email == email).SingleOrDefaultAsync();
        }


    }
}
