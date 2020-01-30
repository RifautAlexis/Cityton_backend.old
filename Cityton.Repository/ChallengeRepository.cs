using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface IChallengeRepository : IRepository<Challenge>
    {

    }

    public class ChallengeRepository : Repository<Challenge>, IChallengeRepository
    {
        public ChallengeRepository(ApplicationContext context) : base(context) { }
    }
}
