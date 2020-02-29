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

    public interface IUserInDiscussionRepository : IRepository<UserInDiscussion>
    {
    }

    public class UserInDiscussionRepository : Repository<UserInDiscussion>, IUserInDiscussionRepository
    {

        public UserInDiscussionRepository(ApplicationContext context) : base(context) { }

    }
}